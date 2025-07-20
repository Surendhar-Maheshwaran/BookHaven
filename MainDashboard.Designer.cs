namespace BookHaven
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            Dashboard = new TabPage();
            Customer = new TabPage();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            clearBtn = new MaterialSkin.Controls.MaterialButton();
            txtAddCustomer = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            label4 = new Label();
            txtPhoneNo = new MaterialSkin.Controls.MaterialTextBox2();
            lblPhone = new Label();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            txtCustomerName = new MaterialSkin.Controls.MaterialTextBox2();
            lblName = new Label();
            lblCustomer = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            customerListView = new MaterialSkin.Controls.MaterialListView();
            CustomerID = new ColumnHeader();
            Customer_Name = new ColumnHeader();
            tabSales = new TabPage();
            tabOrder = new TabPage();
            tabBook = new TabPage();
            tabLogout = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            Customer.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard2.SuspendLayout();
            tabLogout.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Appearance = TabAppearance.Buttons;
            materialTabControl1.Controls.Add(Dashboard);
            materialTabControl1.Controls.Add(Customer);
            materialTabControl1.Controls.Add(tabSales);
            materialTabControl1.Controls.Add(tabOrder);
            materialTabControl1.Controls.Add(tabBook);
            materialTabControl1.Controls.Add(tabLogout);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.HotTrack = true;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.ShowToolTips = true;
            materialTabControl1.Size = new Size(1274, 653);
            materialTabControl1.TabIndex = 0;
            // 
            // Dashboard
            // 
            Dashboard.ImageKey = "icons8-dashboard-24.png";
            Dashboard.Location = new Point(4, 42);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(3);
            Dashboard.Size = new Size(1266, 607);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            Customer.Controls.Add(materialCard3);
            Customer.Controls.Add(materialCard2);
            Customer.ImageKey = "icons8-customer-50.png";
            Customer.Location = new Point(4, 42);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(1266, 607);
            Customer.TabIndex = 1;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialCard6);
            materialCard3.Controls.Add(materialCard4);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(3, 3);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(950, 601);
            materialCard3.TabIndex = 4;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(materialCard7);
            materialCard6.Controls.Add(txtAddress);
            materialCard6.Controls.Add(label4);
            materialCard6.Controls.Add(txtPhoneNo);
            materialCard6.Controls.Add(lblPhone);
            materialCard6.Controls.Add(txtEmail);
            materialCard6.Controls.Add(label2);
            materialCard6.Controls.Add(txtCustomerName);
            materialCard6.Controls.Add(lblName);
            materialCard6.Controls.Add(lblCustomer);
            materialCard6.Depth = 0;
            materialCard6.Dock = DockStyle.Fill;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(14, 14);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(922, 318);
            materialCard6.TabIndex = 11;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(clearBtn);
            materialCard7.Controls.Add(txtAddCustomer);
            materialCard7.Controls.Add(materialButton2);
            materialCard7.Controls.Add(materialButton3);
            materialCard7.Depth = 0;
            materialCard7.Dock = DockStyle.Bottom;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(14, 240);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(894, 64);
            materialCard7.TabIndex = 18;
            // 
            // clearBtn
            // 
            clearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clearBtn.Depth = 0;
            clearBtn.Dock = DockStyle.Right;
            clearBtn.HighEmphasis = true;
            clearBtn.Icon = null;
            clearBtn.Location = new Point(814, 14);
            clearBtn.Margin = new Padding(4, 6, 4, 6);
            clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            clearBtn.Name = "clearBtn";
            clearBtn.NoAccentTextColor = Color.Empty;
            clearBtn.Size = new Size(66, 36);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Clear";
            clearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            clearBtn.UseAccentColor = false;
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // txtAddCustomer
            // 
            txtAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtAddCustomer.Depth = 0;
            txtAddCustomer.Dock = DockStyle.Left;
            txtAddCustomer.HighEmphasis = true;
            txtAddCustomer.Icon = null;
            txtAddCustomer.Location = new Point(14, 14);
            txtAddCustomer.Margin = new Padding(4, 6, 4, 6);
            txtAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            txtAddCustomer.Name = "txtAddCustomer";
            txtAddCustomer.NoAccentTextColor = Color.Empty;
            txtAddCustomer.Size = new Size(64, 36);
            txtAddCustomer.TabIndex = 11;
            txtAddCustomer.Text = "Add ";
            txtAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            txtAddCustomer.UseAccentColor = false;
            txtAddCustomer.UseVisualStyleBackColor = true;
            txtAddCustomer.Click += txtAddCustomer_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(294, 14);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 12;
            materialButton2.Text = "Update";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(578, 14);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(73, 36);
            materialButton3.TabIndex = 13;
            materialButton3.Text = "Delete";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(591, 141);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.ReadOnly = false;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(313, 48);
            txtAddress.TabIndex = 17;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(492, 153);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 16;
            label4.Text = "Address";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.AnimateReadOnly = false;
            txtPhoneNo.BackgroundImageLayout = ImageLayout.None;
            txtPhoneNo.CharacterCasing = CharacterCasing.Normal;
            txtPhoneNo.Depth = 0;
            txtPhoneNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhoneNo.HideSelection = true;
            txtPhoneNo.LeadingIcon = null;
            txtPhoneNo.Location = new Point(136, 141);
            txtPhoneNo.MaxLength = 32767;
            txtPhoneNo.MouseState = MaterialSkin.MouseState.OUT;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.PasswordChar = '\0';
            txtPhoneNo.PrefixSuffixText = null;
            txtPhoneNo.ReadOnly = false;
            txtPhoneNo.RightToLeft = RightToLeft.No;
            txtPhoneNo.SelectedText = "";
            txtPhoneNo.SelectionLength = 0;
            txtPhoneNo.SelectionStart = 0;
            txtPhoneNo.ShortcutsEnabled = true;
            txtPhoneNo.Size = new Size(233, 48);
            txtPhoneNo.TabIndex = 15;
            txtPhoneNo.TabStop = false;
            txtPhoneNo.TextAlign = HorizontalAlignment.Left;
            txtPhoneNo.TrailingIcon = null;
            txtPhoneNo.UseSystemPasswordChar = false;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(20, 153);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(110, 22);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Contact No";
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(590, 54);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(313, 48);
            txtEmail.TabIndex = 13;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(508, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // txtCustomerName
            // 
            txtCustomerName.AnimateReadOnly = false;
            txtCustomerName.BackgroundImageLayout = ImageLayout.None;
            txtCustomerName.CharacterCasing = CharacterCasing.Normal;
            txtCustomerName.Depth = 0;
            txtCustomerName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomerName.HideSelection = true;
            txtCustomerName.LeadingIcon = null;
            txtCustomerName.Location = new Point(136, 54);
            txtCustomerName.MaxLength = 32767;
            txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PasswordChar = '\0';
            txtCustomerName.PrefixSuffixText = null;
            txtCustomerName.ReadOnly = false;
            txtCustomerName.RightToLeft = RightToLeft.No;
            txtCustomerName.SelectedText = "";
            txtCustomerName.SelectionLength = 0;
            txtCustomerName.SelectionStart = 0;
            txtCustomerName.ShortcutsEnabled = true;
            txtCustomerName.Size = new Size(233, 48);
            txtCustomerName.TabIndex = 11;
            txtCustomerName.TabStop = false;
            txtCustomerName.TextAlign = HorizontalAlignment.Left;
            txtCustomerName.TrailingIcon = null;
            txtCustomerName.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(20, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 22);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblCustomer
            // 
            lblCustomer.Dock = DockStyle.Top;
            lblCustomer.Enabled = false;
            lblCustomer.FlatStyle = FlatStyle.Popup;
            lblCustomer.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblCustomer.Location = new Point(14, 14);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(894, 37);
            lblCustomer.TabIndex = 9;
            lblCustomer.Text = "Customer Management";
            lblCustomer.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(materialCard5);
            materialCard4.Controls.Add(tableLayoutPanel1);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Bottom;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(14, 332);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(922, 255);
            materialCard4.TabIndex = 10;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(label3);
            materialCard5.Controls.Add(materialMaskedTextBox2);
            materialCard5.Depth = 0;
            materialCard5.Dock = DockStyle.Top;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(14, 14);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(894, 69);
            materialCard5.TabIndex = 10;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(532, 41);
            label3.TabIndex = 4;
            label3.Text = "Purchase History";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Dock = DockStyle.Right;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = Properties.Resources.icons8_search_50;
            materialMaskedTextBox2.LeaveOnEnterKey = true;
            materialMaskedTextBox2.Location = new Point(598, 14);
            materialMaskedTextBox2.Mask = "";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(282, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 3;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(14, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(894, 186);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialMaskedTextBox1);
            materialCard2.Controls.Add(customerListView);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Right;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(953, 3);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(310, 601);
            materialCard2.TabIndex = 3;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Dock = DockStyle.Top;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = Properties.Resources.icons8_search_50;
            materialMaskedTextBox1.Location = new Point(14, 14);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(282, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 2;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // customerListView
            // 
            customerListView.AutoSizeTable = false;
            customerListView.BackColor = Color.FromArgb(255, 255, 255);
            customerListView.BorderStyle = BorderStyle.None;
            customerListView.Columns.AddRange(new ColumnHeader[] { CustomerID, Customer_Name });
            customerListView.Depth = 0;
            customerListView.Dock = DockStyle.Bottom;
            customerListView.FullRowSelect = true;
            customerListView.Location = new Point(14, 14);
            customerListView.MinimumSize = new Size(200, 100);
            customerListView.MouseLocation = new Point(-1, -1);
            customerListView.MouseState = MaterialSkin.MouseState.OUT;
            customerListView.Name = "customerListView";
            customerListView.OwnerDraw = true;
            customerListView.Size = new Size(282, 573);
            customerListView.TabIndex = 0;
            customerListView.UseCompatibleStateImageBehavior = false;
            customerListView.View = View.Details;
            // 
            // CustomerID
            // 
            CustomerID.Text = "Customer ID";
            // 
            // Customer_Name
            // 
            Customer_Name.Text = "Customer Name";
            // 
            // tabSales
            // 
            tabSales.ImageKey = "icons8-sales-50.png";
            tabSales.Location = new Point(4, 42);
            tabSales.Name = "tabSales";
            tabSales.Size = new Size(1266, 607);
            tabSales.TabIndex = 2;
            tabSales.Text = "Sales";
            tabSales.ToolTipText = "Sales";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // tabOrder
            // 
            tabOrder.ImageKey = "icons8-order-50.png";
            tabOrder.Location = new Point(4, 42);
            tabOrder.Name = "tabOrder";
            tabOrder.Size = new Size(1266, 607);
            tabOrder.TabIndex = 3;
            tabOrder.Text = "Orders";
            tabOrder.ToolTipText = "Order";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // tabBook
            // 
            tabBook.ImageKey = "icons8-book-50.png";
            tabBook.Location = new Point(4, 42);
            tabBook.Name = "tabBook";
            tabBook.Size = new Size(1266, 607);
            tabBook.TabIndex = 4;
            tabBook.Text = "Inventory";
            tabBook.ToolTipText = "Book Management";
            tabBook.UseVisualStyleBackColor = true;
            // 
            // tabLogout
            // 
            tabLogout.Controls.Add(materialCard1);
            tabLogout.ImageKey = "icons8-logout-26.png";
            tabLogout.Location = new Point(4, 42);
            tabLogout.Name = "tabLogout";
            tabLogout.Size = new Size(1266, 607);
            tabLogout.TabIndex = 5;
            tabLogout.Text = "Log Out";
            tabLogout.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnCancel);
            materialCard1.Controls.Add(btnLogout);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(118, 30);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(704, 309);
            materialCard1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnCancel.Depth = 0;
            btnCancel.ForeColor = Color.IndianRed;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(354, 188);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(282, 188);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(64, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Yes";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 94);
            label1.Name = "label1";
            label1.Size = new Size(435, 38);
            label1.TabIndex = 0;
            label1.Text = "Are you sure want to Log out";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-customer-50.png");
            imageList1.Images.SetKeyName(1, "icons8-book-50.png");
            imageList1.Images.SetKeyName(2, "icons8-logout-26.png");
            imageList1.Images.SetKeyName(3, "icons8-order-50.png");
            imageList1.Images.SetKeyName(4, "icons8-sales-50.png");
            imageList1.Images.SetKeyName(5, "icons8-dashboard-24.png");
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "MainDashboard";
            Text = "Book Haven - Sales Dashboard";
            materialTabControl1.ResumeLayout(false);
            Customer.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            tabLogout.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Dashboard;
        private TabPage Customer;
        private ImageList imageList1;
        private TabPage tabSales;
        private TabPage tabOrder;
        private TabPage tabBook;
        private TabPage tabLogout;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialListView customerListView;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label label3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton txtAddCustomer;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox2 txtPhoneNo;
        private Label lblPhone;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCustomerName;
        private Label lblName;
        private Label lblCustomer;
        private MaterialSkin.Controls.MaterialButton clearBtn;
        private ColumnHeader CustomerID;
        private ColumnHeader Customer_Name;
    }
}