namespace NFSMWTrainer
{
    partial class TrainerForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RainbowCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BlueTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.GreenTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RedTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.ControlTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorCheckBox2 = new System.Windows.Forms.CheckBox();
            this.Rainbow2CheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BlueTrack2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.GreenTrack2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.RedTrack2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.Rainbow = new System.Windows.Forms.Timer(this.components);
            this.Rainbow2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlateBox = new System.Windows.Forms.CheckBox();
            this.Nitro = new System.Windows.Forms.CheckBox();
            this.ActiveButton = new System.Windows.Forms.CheckBox();
            this.AeroDownforceLabel = new System.Windows.Forms.Label();
            this.AeroSpeedLabel = new System.Windows.Forms.Label();
            this.ShiftDelayLabel = new System.Windows.Forms.Label();
            this.AeroDownforceUpDown = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.AeroSpeedUpDown = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.ShiftDelayUpDown = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.AccelerationUpDown = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.Plate = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AeroDownforceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeroSpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---Police-Car---",
            "[122713] Crown Vic Interceptor",
            "[510072] Ford SUV Interceptor",
            "[122699] Corvette Z06",
            "[122706] SRT8 Charger",
            "[1467242] S.W.A.T",
            "---Cars---",
            "[1085698] Alfa Romeo 4C",
            "[2196263] Alfa Romeo Mito",
            "[1160082] Ariel Atom V8",
            "[2196529] Aston Martin DB5",
            "[2196595] Aston Martin DBS",
            "[122672] Aston Martin Vantage",
            "[1160139] Audi A1",
            "[122675] Audi R8",
            "[2196131] Audi RS3",
            "[1160025] BAC Mono",
            "[866774] Bentley Supersports",
            "[2196065] BMW M1",
            "[122682] BMW M3 E92",
            "[393276] BMW M3 E46",
            "[122692] Bugatti Veyron",
            "[2076005] Bugatti Veyron Vitesse",
            "[393001] Caterham R500",
            "[621053] Chevrolet Camaro ZL1",
            "[122701] Chevrolet Corvette ZR1",
            "[2196466] Dodge Charger R/T",
            "[300097] Ford Raptor F150",
            "[2196197] Ford Fiesta ST",
            "[1160480] Ford Focus RS500",
            "[122714] Ford GT",
            "[122716] Ford Mustang Boss 302",
            "[2076137] Hennessey Venom",
            "[1399602] Jaguar XKR",
            "[589261] Koenigsegg Agera",
            "[392074] Lamborghini Aventador",
            "[2076203] Lamborghini Aventador J",
            "[1085091] Lamborghini Countach",
            "[2076339] Lamborghini Diablo",
            "[1085633] Lamborghini Gallardo",
            "[1097100] Lancia Delta HF",
            "[1085958] Land Rover Evoque",
            "[1085511] Lexus LFA",
            "[1551590] Marussia B2",
            "[122757] Maserati GT MC12",
            "[2076070] McLaren F1",
            "[122765] McLaren MP4-12C",
            "[122769] Mercedes Benz SL 65",
            "[122773] Mercedes Benz SLS",
            "[866832] Mitsubishi Lancer Evo",
            "[2076462] Nissan 350Z",
            "[435169] Nissan R35",
            "[2076524] Nissan R34",
            "[535435] Pagani Huayra",
            "[2076266] Pagani Zonda R",
            "[2196399] Pontiac Firebird",
            "[1085007] Porsche 911",
            "[2076399] Porsche 911 GT2",
            "[1085186] Porsche 911 Turbo 3",
            "[2196000] Porsche 918 Spyder",
            "[1085830] Porsche 918 Concept",
            "[535621] Porsche Panamera Turbo",
            "[1085576] Shelby Cobra 427",
            "[2196334] Shelby GT500",
            "[122704] Dodge Challenger SRT8",
            "[1160350] Dodge Viper SRT8",
            "[122814] Subaru Impreza STI",
            "[1085764] Tesla Roadster Sport"});
            this.comboBox1.Location = new System.Drawing.Point(56, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RainbowCheckBox);
            this.groupBox1.Controls.Add(this.ColorCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BlueTrack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GreenTrack);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RedTrack);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Color (Car Color)";
            // 
            // RainbowCheckBox
            // 
            this.RainbowCheckBox.AutoSize = true;
            this.RainbowCheckBox.Location = new System.Drawing.Point(193, 95);
            this.RainbowCheckBox.Name = "RainbowCheckBox";
            this.RainbowCheckBox.Size = new System.Drawing.Size(68, 17);
            this.RainbowCheckBox.TabIndex = 10;
            this.RainbowCheckBox.Text = "Rainbow";
            this.RainbowCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorCheckBox
            // 
            this.ColorCheckBox.AutoSize = true;
            this.ColorCheckBox.Location = new System.Drawing.Point(6, 95);
            this.ColorCheckBox.Name = "ColorCheckBox";
            this.ColorCheckBox.Size = new System.Drawing.Size(48, 17);
            this.ColorCheckBox.TabIndex = 9;
            this.ColorCheckBox.Text = "Start";
            this.ColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Blue";
            // 
            // BlueTrack
            // 
            this.BlueTrack.Location = new System.Drawing.Point(56, 77);
            this.BlueTrack.Maximum = 255;
            this.BlueTrack.Name = "BlueTrack";
            this.BlueTrack.Size = new System.Drawing.Size(205, 23);
            this.BlueTrack.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.BlueTrack.TabIndex = 4;
            this.BlueTrack.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BlueTrack.Value = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Green";
            // 
            // GreenTrack
            // 
            this.GreenTrack.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.GreenTrack.Location = new System.Drawing.Point(56, 48);
            this.GreenTrack.Maximum = 255;
            this.GreenTrack.Name = "GreenTrack";
            this.GreenTrack.Size = new System.Drawing.Size(205, 23);
            this.GreenTrack.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.GreenTrack.TabIndex = 2;
            this.GreenTrack.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.GreenTrack.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // RedTrack
            // 
            this.RedTrack.LargeChange = 1;
            this.RedTrack.Location = new System.Drawing.Point(56, 19);
            this.RedTrack.Maximum = 255;
            this.RedTrack.Minimum = 1;
            this.RedTrack.MouseWheelBarPartitions = 1;
            this.RedTrack.Name = "RedTrack";
            this.RedTrack.Size = new System.Drawing.Size(205, 23);
            this.RedTrack.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.RedTrack.TabIndex = 0;
            this.RedTrack.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RedTrack.Value = 1;
            // 
            // ControlTimer
            // 
            this.ControlTimer.Enabled = true;
            this.ControlTimer.Interval = 1;
            this.ControlTimer.Tick += new System.EventHandler(this.ControlTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColorCheckBox2);
            this.groupBox2.Controls.Add(this.Rainbow2CheckBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BlueTrack2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.GreenTrack2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RedTrack2);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Color (2)";
            // 
            // ColorCheckBox2
            // 
            this.ColorCheckBox2.AutoSize = true;
            this.ColorCheckBox2.Location = new System.Drawing.Point(6, 95);
            this.ColorCheckBox2.Name = "ColorCheckBox2";
            this.ColorCheckBox2.Size = new System.Drawing.Size(48, 17);
            this.ColorCheckBox2.TabIndex = 12;
            this.ColorCheckBox2.Text = "Start";
            this.ColorCheckBox2.UseVisualStyleBackColor = true;
            // 
            // Rainbow2CheckBox
            // 
            this.Rainbow2CheckBox.AutoSize = true;
            this.Rainbow2CheckBox.Location = new System.Drawing.Point(193, 95);
            this.Rainbow2CheckBox.Name = "Rainbow2CheckBox";
            this.Rainbow2CheckBox.Size = new System.Drawing.Size(68, 17);
            this.Rainbow2CheckBox.TabIndex = 11;
            this.Rainbow2CheckBox.Text = "Rainbow";
            this.Rainbow2CheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Blue";
            // 
            // BlueTrack2
            // 
            this.BlueTrack2.Location = new System.Drawing.Point(56, 77);
            this.BlueTrack2.Maximum = 255;
            this.BlueTrack2.Name = "BlueTrack2";
            this.BlueTrack2.Size = new System.Drawing.Size(205, 23);
            this.BlueTrack2.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.BlueTrack2.TabIndex = 4;
            this.BlueTrack2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BlueTrack2.Value = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Green";
            // 
            // GreenTrack2
            // 
            this.GreenTrack2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.GreenTrack2.Location = new System.Drawing.Point(56, 48);
            this.GreenTrack2.Maximum = 255;
            this.GreenTrack2.Name = "GreenTrack2";
            this.GreenTrack2.Size = new System.Drawing.Size(205, 23);
            this.GreenTrack2.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.GreenTrack2.TabIndex = 2;
            this.GreenTrack2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.GreenTrack2.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Red";
            // 
            // RedTrack2
            // 
            this.RedTrack2.Location = new System.Drawing.Point(56, 19);
            this.RedTrack2.Maximum = 255;
            this.RedTrack2.Name = "RedTrack2";
            this.RedTrack2.Size = new System.Drawing.Size(205, 23);
            this.RedTrack2.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.RedTrack2.TabIndex = 0;
            this.RedTrack2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RedTrack2.Value = 0;
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Location = new System.Drawing.Point(400, 261);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(68, 17);
            this.TopMostCheckBox.TabIndex = 8;
            this.TopMostCheckBox.Text = "TopMost";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMost_CheckedChanged);
            // 
            // Rainbow
            // 
            this.Rainbow.Tick += new System.EventHandler(this.Rainbow_Tick);
            // 
            // Rainbow2
            // 
            this.Rainbow2.Tick += new System.EventHandler(this.Rainbow2_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlateBox);
            this.groupBox3.Controls.Add(this.Nitro);
            this.groupBox3.Controls.Add(this.ActiveButton);
            this.groupBox3.Controls.Add(this.AeroDownforceLabel);
            this.groupBox3.Controls.Add(this.AeroSpeedLabel);
            this.groupBox3.Controls.Add(this.ShiftDelayLabel);
            this.groupBox3.Controls.Add(this.AeroDownforceUpDown);
            this.groupBox3.Controls.Add(this.AeroSpeedUpDown);
            this.groupBox3.Controls.Add(this.ShiftDelayUpDown);
            this.groupBox3.Controls.Add(this.AccelerationLabel);
            this.groupBox3.Controls.Add(this.AccelerationUpDown);
            this.groupBox3.Controls.Add(this.Plate);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(289, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 195);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car";
            // 
            // PlateBox
            // 
            this.PlateBox.AutoSize = true;
            this.PlateBox.Location = new System.Drawing.Point(106, 21);
            this.PlateBox.Name = "PlateBox";
            this.PlateBox.Size = new System.Drawing.Size(56, 17);
            this.PlateBox.TabIndex = 22;
            this.PlateBox.Text = "Active";
            this.PlateBox.UseVisualStyleBackColor = true;
            // 
            // Nitro
            // 
            this.Nitro.AutoSize = true;
            this.Nitro.Location = new System.Drawing.Point(6, 178);
            this.Nitro.Name = "Nitro";
            this.Nitro.Size = new System.Drawing.Size(48, 17);
            this.Nitro.TabIndex = 21;
            this.Nitro.Text = "N2O";
            this.Nitro.UseVisualStyleBackColor = true;
            // 
            // ActiveButton
            // 
            this.ActiveButton.AutoSize = true;
            this.ActiveButton.Location = new System.Drawing.Point(123, 176);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(56, 17);
            this.ActiveButton.TabIndex = 20;
            this.ActiveButton.Text = "Active";
            this.ActiveButton.UseVisualStyleBackColor = true;
            // 
            // AeroDownforceLabel
            // 
            this.AeroDownforceLabel.AutoSize = true;
            this.AeroDownforceLabel.Location = new System.Drawing.Point(16, 153);
            this.AeroDownforceLabel.Name = "AeroDownforceLabel";
            this.AeroDownforceLabel.Size = new System.Drawing.Size(84, 13);
            this.AeroDownforceLabel.TabIndex = 19;
            this.AeroDownforceLabel.Text = "Aéro Downforce";
            // 
            // AeroSpeedLabel
            // 
            this.AeroSpeedLabel.AutoSize = true;
            this.AeroSpeedLabel.Location = new System.Drawing.Point(16, 124);
            this.AeroSpeedLabel.Name = "AeroSpeedLabel";
            this.AeroSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.AeroSpeedLabel.TabIndex = 18;
            this.AeroSpeedLabel.Text = "Aéro Speed";
            // 
            // ShiftDelayLabel
            // 
            this.ShiftDelayLabel.AutoSize = true;
            this.ShiftDelayLabel.Location = new System.Drawing.Point(16, 87);
            this.ShiftDelayLabel.Name = "ShiftDelayLabel";
            this.ShiftDelayLabel.Size = new System.Drawing.Size(58, 13);
            this.ShiftDelayLabel.TabIndex = 17;
            this.ShiftDelayLabel.Text = "Shift Delay";
            // 
            // AeroDownforceUpDown
            // 
            this.AeroDownforceUpDown.BackColor = System.Drawing.Color.Transparent;
            this.AeroDownforceUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AeroDownforceUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AeroDownforceUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AeroDownforceUpDown.Location = new System.Drawing.Point(104, 143);
            this.AeroDownforceUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AeroDownforceUpDown.Name = "AeroDownforceUpDown";
            this.AeroDownforceUpDown.Size = new System.Drawing.Size(69, 27);
            this.AeroDownforceUpDown.TabIndex = 16;
            // 
            // AeroSpeedUpDown
            // 
            this.AeroSpeedUpDown.BackColor = System.Drawing.Color.Transparent;
            this.AeroSpeedUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AeroSpeedUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AeroSpeedUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AeroSpeedUpDown.Location = new System.Drawing.Point(104, 110);
            this.AeroSpeedUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AeroSpeedUpDown.Name = "AeroSpeedUpDown";
            this.AeroSpeedUpDown.Size = new System.Drawing.Size(69, 27);
            this.AeroSpeedUpDown.TabIndex = 15;
            // 
            // ShiftDelayUpDown
            // 
            this.ShiftDelayUpDown.BackColor = System.Drawing.Color.Transparent;
            this.ShiftDelayUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShiftDelayUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShiftDelayUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShiftDelayUpDown.Location = new System.Drawing.Point(104, 77);
            this.ShiftDelayUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ShiftDelayUpDown.Name = "ShiftDelayUpDown";
            this.ShiftDelayUpDown.Size = new System.Drawing.Size(69, 27);
            this.ShiftDelayUpDown.TabIndex = 14;
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(16, 50);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(66, 13);
            this.AccelerationLabel.TabIndex = 13;
            this.AccelerationLabel.Text = "Acceleration";
            // 
            // AccelerationUpDown
            // 
            this.AccelerationUpDown.BackColor = System.Drawing.Color.Transparent;
            this.AccelerationUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccelerationUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AccelerationUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccelerationUpDown.Location = new System.Drawing.Point(104, 44);
            this.AccelerationUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AccelerationUpDown.Name = "AccelerationUpDown";
            this.AccelerationUpDown.Size = new System.Drawing.Size(69, 27);
            this.AccelerationUpDown.TabIndex = 12;
            // 
            // Plate
            // 
            this.Plate.Location = new System.Drawing.Point(6, 19);
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(94, 20);
            this.Plate.TabIndex = 11;
            this.Plate.Text = "NFS4SPD";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(193, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Rainbow";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TopMostCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainerForm";
            this.Text = "Trainer V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AeroDownforceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AeroSpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RedTrack;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar BlueTrack;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar GreenTrack;
        private System.Windows.Forms.Timer ControlTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar BlueTrack2;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar GreenTrack2;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RedTrack2;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox ColorCheckBox;
        private System.Windows.Forms.CheckBox RainbowCheckBox;
        private System.Windows.Forms.Timer Rainbow;
        private System.Windows.Forms.Timer Rainbow2;
        private System.Windows.Forms.CheckBox Rainbow2CheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Plate;
        private System.Windows.Forms.Label AccelerationLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown AccelerationUpDown;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown AeroDownforceUpDown;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown AeroSpeedUpDown;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown ShiftDelayUpDown;
        private System.Windows.Forms.Label AeroDownforceLabel;
        private System.Windows.Forms.Label AeroSpeedLabel;
        private System.Windows.Forms.Label ShiftDelayLabel;
        private System.Windows.Forms.CheckBox ActiveButton;
        private System.Windows.Forms.CheckBox ColorCheckBox2;
        private System.Windows.Forms.CheckBox Nitro;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox PlateBox;
    }
}

