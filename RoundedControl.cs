using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    // ==========================================
    // 1. ROUNDED BUTTON
    // ==========================================
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(40, 80, 40);
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = GetRoundedPath(this.ClientRectangle, BorderRadius);
            this.Region = new Region(path);

            // Fill background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pe.Graphics.FillPath(brush, path);
            }

            // Draw centered text
            TextFormatFlags flags =
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.WordBreak;

            TextRenderer.DrawText(
                pe.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor,
                flags
            );
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top Left
            path.AddArc(arcRect, 180, 90);

            // Top Right
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // Bottom Right
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // Bottom Left
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;
        }
    }


    // ==========================================
    // 2. ROUNDED TEXTBOX WITH PLACEHOLDER
    // ==========================================
    public class RoundedTextBox : UserControl
    {
        private TextBox innerTextBox;

        private int borderRadius = 15;

        private bool isPlaceholderActive = false;

        private string placeholderText = "";

        private bool useSystemPasswordChar = false;
        internal bool ReadOnly;


        // ==========================================
        // PROPERTIES
        // ==========================================

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        // Actual user text
        public new string Text
        {
            get
            {
                return isPlaceholderActive ? "" : innerTextBox.Text;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    ShowPlaceholder();
                }
                else
                {
                    RemovePlaceholder();

                    innerTextBox.Text = value;
                }
            }
        }

        // Placeholder text
        public string Placeholder
        {
            get { return placeholderText; }

            set
            {
                placeholderText = value;

                if (string.IsNullOrWhiteSpace(innerTextBox.Text))
                {
                    ShowPlaceholder();
                }
            }
        }

        public new Color ForeColor
        {
            get { return innerTextBox.ForeColor; }
            set { innerTextBox.ForeColor = value; }
        }

        public bool UseSystemPasswordChar
        {
            get { return useSystemPasswordChar; }

            set
            {
                useSystemPasswordChar = value;

                if (!isPlaceholderActive)
                {
                    innerTextBox.UseSystemPasswordChar = value;
                }
            }
        }

        public bool Multiline { get; internal set; }


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public RoundedTextBox()
        {
            innerTextBox = new TextBox();

            innerTextBox.BorderStyle = BorderStyle.None;

            innerTextBox.Font = new Font("Segoe UI", 11F);

            innerTextBox.BackColor = Color.FromArgb(240, 240, 240);

            innerTextBox.ForeColor = Color.FromArgb(30, 60, 30);

            innerTextBox.Location = new Point(10, 8);

            innerTextBox.Width = this.Width - 20;

            innerTextBox.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // EVENTS
            innerTextBox.MouseClick += InnerTextBox_MouseClick;

            innerTextBox.KeyDown += InnerTextBox_KeyDown;

            innerTextBox.Leave += InnerTextBox_Leave;

            this.Controls.Add(innerTextBox);

            this.BackColor = Color.FromArgb(240, 240, 240);

            this.Size = new Size(340, 40);

            // Show placeholder initially
            ShowPlaceholder();
        }


        // ==========================================
        // EVENTS
        // ==========================================

        // Only remove placeholder when user clicks
        private void InnerTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPlaceholderActive)
            {
                RemovePlaceholder();
            }
        }

        // Or starts typing
        private void InnerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPlaceholderActive)
            {
                RemovePlaceholder();
            }
        }

        // Restore placeholder if empty
        private void InnerTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(innerTextBox.Text))
            {
                ShowPlaceholder();
            }
        }


        // ==========================================
        // PLACEHOLDER METHODS
        // ==========================================

        private void ShowPlaceholder()
        {
            if (!string.IsNullOrWhiteSpace(placeholderText))
            {
                isPlaceholderActive = true;

                innerTextBox.Text = placeholderText;

                innerTextBox.ForeColor = Color.Gray;

                // Disable password bullets for placeholder
                innerTextBox.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholderActive)
            {
                isPlaceholderActive = false;

                innerTextBox.Text = "";

                innerTextBox.ForeColor = Color.FromArgb(30, 60, 30);

                // Restore password bullets if needed
                innerTextBox.UseSystemPasswordChar = useSystemPasswordChar;
            }
        }


        // ==========================================
        // RESIZE
        // ==========================================

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            innerTextBox.Location =
                new Point(10, (this.Height - innerTextBox.Height) / 2);

            innerTextBox.Width = this.Width - 20;
        }


        // ==========================================
        // PAINT
        // ==========================================

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path =
                GetRoundedPath(this.ClientRectangle, borderRadius);

            this.Region = new Region(path);

            // Fill background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Border
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }


        // ==========================================
        // ROUNDED PATH
        // ==========================================

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            Rectangle arcRect =
                new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top Left
            path.AddArc(arcRect, 180, 90);

            // Top Right
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // Bottom Right
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // Bottom Left
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
