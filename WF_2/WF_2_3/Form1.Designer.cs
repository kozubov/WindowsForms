namespace WF_2_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFuelQuantity = new System.Windows.Forms.TextBox();
            this.labelSumm = new System.Windows.Forms.Label();
            this.labelLitre = new System.Windows.Forms.Label();
            this.textBoxFuelSumm = new System.Windows.Forms.TextBox();
            this.groupBoxFuelChoose = new System.Windows.Forms.GroupBox();
            this.radioButtonFuelSumm = new System.Windows.Forms.RadioButton();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.comboBoxFuelType = new System.Windows.Forms.ComboBox();
            this.labelFuelPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.labelColumnQuantity = new System.Windows.Forms.Label();
            this.labelColumnPrice = new System.Windows.Forms.Label();
            this.textBoxColaSumm = new System.Windows.Forms.TextBox();
            this.textBoxPotatoSumm = new System.Windows.Forms.TextBox();
            this.textBoxBurgerSumm = new System.Windows.Forms.TextBox();
            this.textBoxDogSumm = new System.Windows.Forms.TextBox();
            this.textBoxColaPrice = new System.Windows.Forms.TextBox();
            this.textBoxPotatoPrice = new System.Windows.Forms.TextBox();
            this.textBoxBurgerPrice = new System.Windows.Forms.TextBox();
            this.textBoxDogPrice = new System.Windows.Forms.TextBox();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.checkBoxPotFry = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSummAll = new System.Windows.Forms.Label();
            this.buttonSummAll = new System.Windows.Forms.Button();
            this.groupBoxTotalFuel = new System.Windows.Forms.GroupBox();
            this.labelShowTotalFuel = new System.Windows.Forms.Label();
            this.labelTotalQorSumm = new System.Windows.Forms.Label();
            this.groupBoxTotalCafe = new System.Windows.Forms.GroupBox();
            this.labelTotalCafe = new System.Windows.Forms.Label();
            this.labelTotalCafeSumm = new System.Windows.Forms.Label();
            this.labelTOTALMONEY = new System.Windows.Forms.Label();
            this.labelTotalmoneyInfo = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelClientsShow = new System.Windows.Forms.Label();
            this.labelAvgCheck = new System.Windows.Forms.Label();
            this.labelAvgCheckShow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxFuel.SuspendLayout();
            this.groupBoxFuelChoose.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTotalFuel.SuspendLayout();
            this.groupBoxTotalCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.label2);
            this.groupBoxFuel.Controls.Add(this.textBoxFuelQuantity);
            this.groupBoxFuel.Controls.Add(this.labelSumm);
            this.groupBoxFuel.Controls.Add(this.labelLitre);
            this.groupBoxFuel.Controls.Add(this.textBoxFuelSumm);
            this.groupBoxFuel.Controls.Add(this.groupBoxFuelChoose);
            this.groupBoxFuel.Controls.Add(this.comboBoxFuelType);
            this.groupBoxFuel.Controls.Add(this.labelFuelPrice);
            this.groupBoxFuel.Controls.Add(this.labelPrice);
            this.groupBoxFuel.Controls.Add(this.labelFuel);
            this.groupBoxFuel.Location = new System.Drawing.Point(24, 64);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(250, 201);
            this.groupBoxFuel.TabIndex = 0;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Заправка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "грн./л.";
            // 
            // textBoxFuelQuantity
            // 
            this.textBoxFuelQuantity.Location = new System.Drawing.Point(117, 116);
            this.textBoxFuelQuantity.Name = "textBoxFuelQuantity";
            this.textBoxFuelQuantity.Size = new System.Drawing.Size(80, 20);
            this.textBoxFuelQuantity.TabIndex = 9;
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(214, 158);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(27, 13);
            this.labelSumm.TabIndex = 8;
            this.labelSumm.Text = "грн.";
            // 
            // labelLitre
            // 
            this.labelLitre.AutoSize = true;
            this.labelLitre.Location = new System.Drawing.Point(213, 121);
            this.labelLitre.Name = "labelLitre";
            this.labelLitre.Size = new System.Drawing.Size(16, 13);
            this.labelLitre.TabIndex = 7;
            this.labelLitre.Text = "л.";
            // 
            // textBoxFuelSumm
            // 
            this.textBoxFuelSumm.Location = new System.Drawing.Point(117, 155);
            this.textBoxFuelSumm.Name = "textBoxFuelSumm";
            this.textBoxFuelSumm.ReadOnly = true;
            this.textBoxFuelSumm.Size = new System.Drawing.Size(80, 20);
            this.textBoxFuelSumm.TabIndex = 6;
            this.textBoxFuelSumm.TextChanged += new System.EventHandler(this.textBoxFuelSumm_TextChanged);
            // 
            // groupBoxFuelChoose
            // 
            this.groupBoxFuelChoose.Controls.Add(this.radioButtonFuelSumm);
            this.groupBoxFuelChoose.Controls.Add(this.radioButtonQuantity);
            this.groupBoxFuelChoose.Location = new System.Drawing.Point(14, 105);
            this.groupBoxFuelChoose.Name = "groupBoxFuelChoose";
            this.groupBoxFuelChoose.Size = new System.Drawing.Size(95, 85);
            this.groupBoxFuelChoose.TabIndex = 4;
            this.groupBoxFuelChoose.TabStop = false;
            // 
            // radioButtonFuelSumm
            // 
            this.radioButtonFuelSumm.AutoSize = true;
            this.radioButtonFuelSumm.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFuelSumm.Name = "radioButtonFuelSumm";
            this.radioButtonFuelSumm.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFuelSumm.TabIndex = 1;
            this.radioButtonFuelSumm.Text = "Сумма";
            this.radioButtonFuelSumm.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Checked = true;
            this.radioButtonQuantity.Location = new System.Drawing.Point(6, 11);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(84, 17);
            this.radioButtonQuantity.TabIndex = 0;
            this.radioButtonQuantity.TabStop = true;
            this.radioButtonQuantity.Text = "Количество";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            this.radioButtonQuantity.CheckedChanged += new System.EventHandler(this.radioButtonQuantity_CheckedChanged);
            // 
            // comboBoxFuelType
            // 
            this.comboBoxFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFuelType.FormattingEnabled = true;
            this.comboBoxFuelType.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "Газ",
            "ДТ"});
            this.comboBoxFuelType.Location = new System.Drawing.Point(76, 38);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFuelType.TabIndex = 3;
            this.comboBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuelType_SelectedIndexChanged);
            // 
            // labelFuelPrice
            // 
            this.labelFuelPrice.AutoSize = true;
            this.labelFuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuelPrice.Location = new System.Drawing.Point(148, 79);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.Size = new System.Drawing.Size(49, 20);
            this.labelFuelPrice.TabIndex = 2;
            this.labelFuelPrice.Text = "28.74";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(19, 79);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(17, 45);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(50, 13);
            this.labelFuel.TabIndex = 0;
            this.labelFuel.Text = "Топливо";
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.labelColumnQuantity);
            this.groupBoxCafe.Controls.Add(this.labelColumnPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxColaSumm);
            this.groupBoxCafe.Controls.Add(this.textBoxPotatoSumm);
            this.groupBoxCafe.Controls.Add(this.textBoxBurgerSumm);
            this.groupBoxCafe.Controls.Add(this.textBoxDogSumm);
            this.groupBoxCafe.Controls.Add(this.textBoxColaPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxPotatoPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxBurgerPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxDogPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxCola);
            this.groupBoxCafe.Controls.Add(this.checkBoxPotFry);
            this.groupBoxCafe.Controls.Add(this.checkBoxBurger);
            this.groupBoxCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxCafe.Location = new System.Drawing.Point(291, 64);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(290, 204);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Кафе";
            // 
            // labelColumnQuantity
            // 
            this.labelColumnQuantity.AutoSize = true;
            this.labelColumnQuantity.Location = new System.Drawing.Point(204, 18);
            this.labelColumnQuantity.Name = "labelColumnQuantity";
            this.labelColumnQuantity.Size = new System.Drawing.Size(66, 13);
            this.labelColumnQuantity.TabIndex = 13;
            this.labelColumnQuantity.Text = "Количество";
            // 
            // labelColumnPrice
            // 
            this.labelColumnPrice.AutoSize = true;
            this.labelColumnPrice.Location = new System.Drawing.Point(122, 18);
            this.labelColumnPrice.Name = "labelColumnPrice";
            this.labelColumnPrice.Size = new System.Drawing.Size(59, 13);
            this.labelColumnPrice.TabIndex = 12;
            this.labelColumnPrice.Text = "Цена, грн.";
            // 
            // textBoxColaSumm
            // 
            this.textBoxColaSumm.Location = new System.Drawing.Point(208, 160);
            this.textBoxColaSumm.Name = "textBoxColaSumm";
            this.textBoxColaSumm.ReadOnly = true;
            this.textBoxColaSumm.Size = new System.Drawing.Size(42, 20);
            this.textBoxColaSumm.TabIndex = 11;
            this.textBoxColaSumm.TextChanged += new System.EventHandler(this.textBoxColaSumm_TextChanged);
            // 
            // textBoxPotatoSumm
            // 
            this.textBoxPotatoSumm.Location = new System.Drawing.Point(208, 123);
            this.textBoxPotatoSumm.Name = "textBoxPotatoSumm";
            this.textBoxPotatoSumm.ReadOnly = true;
            this.textBoxPotatoSumm.Size = new System.Drawing.Size(42, 20);
            this.textBoxPotatoSumm.TabIndex = 10;
            this.textBoxPotatoSumm.TextChanged += new System.EventHandler(this.textBoxPotatoSumm_TextChanged);
            // 
            // textBoxBurgerSumm
            // 
            this.textBoxBurgerSumm.Location = new System.Drawing.Point(208, 83);
            this.textBoxBurgerSumm.Name = "textBoxBurgerSumm";
            this.textBoxBurgerSumm.ReadOnly = true;
            this.textBoxBurgerSumm.Size = new System.Drawing.Size(42, 20);
            this.textBoxBurgerSumm.TabIndex = 9;
            this.textBoxBurgerSumm.TextChanged += new System.EventHandler(this.textBoxBurgerSumm_TextChanged);
            // 
            // textBoxDogSumm
            // 
            this.textBoxDogSumm.Location = new System.Drawing.Point(208, 43);
            this.textBoxDogSumm.Name = "textBoxDogSumm";
            this.textBoxDogSumm.ReadOnly = true;
            this.textBoxDogSumm.Size = new System.Drawing.Size(42, 20);
            this.textBoxDogSumm.TabIndex = 8;
            this.textBoxDogSumm.TextChanged += new System.EventHandler(this.textBoxDogSumm_TextChanged);
            // 
            // textBoxColaPrice
            // 
            this.textBoxColaPrice.Location = new System.Drawing.Point(124, 160);
            this.textBoxColaPrice.Name = "textBoxColaPrice";
            this.textBoxColaPrice.ReadOnly = true;
            this.textBoxColaPrice.Size = new System.Drawing.Size(46, 20);
            this.textBoxColaPrice.TabIndex = 7;
            this.textBoxColaPrice.Text = "18,00";
            // 
            // textBoxPotatoPrice
            // 
            this.textBoxPotatoPrice.Location = new System.Drawing.Point(124, 123);
            this.textBoxPotatoPrice.Name = "textBoxPotatoPrice";
            this.textBoxPotatoPrice.ReadOnly = true;
            this.textBoxPotatoPrice.Size = new System.Drawing.Size(46, 20);
            this.textBoxPotatoPrice.TabIndex = 6;
            this.textBoxPotatoPrice.Text = "12,00";
            // 
            // textBoxBurgerPrice
            // 
            this.textBoxBurgerPrice.Location = new System.Drawing.Point(125, 84);
            this.textBoxBurgerPrice.Name = "textBoxBurgerPrice";
            this.textBoxBurgerPrice.ReadOnly = true;
            this.textBoxBurgerPrice.Size = new System.Drawing.Size(45, 20);
            this.textBoxBurgerPrice.TabIndex = 5;
            this.textBoxBurgerPrice.Text = "15,00";
            // 
            // textBoxDogPrice
            // 
            this.textBoxDogPrice.Location = new System.Drawing.Point(125, 44);
            this.textBoxDogPrice.Name = "textBoxDogPrice";
            this.textBoxDogPrice.ReadOnly = true;
            this.textBoxDogPrice.Size = new System.Drawing.Size(45, 20);
            this.textBoxDogPrice.TabIndex = 4;
            this.textBoxDogPrice.Text = "10,00";
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.Location = new System.Drawing.Point(15, 160);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(79, 17);
            this.checkBoxCola.TabIndex = 3;
            this.checkBoxCola.Text = "Кока Кола";
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.CheckedChanged += new System.EventHandler(this.checkBoxCola_CheckedChanged);
            // 
            // checkBoxPotFry
            // 
            this.checkBoxPotFry.AutoSize = true;
            this.checkBoxPotFry.Location = new System.Drawing.Point(15, 123);
            this.checkBoxPotFry.Name = "checkBoxPotFry";
            this.checkBoxPotFry.Size = new System.Drawing.Size(102, 17);
            this.checkBoxPotFry.TabIndex = 2;
            this.checkBoxPotFry.Text = "Картошка Фри";
            this.checkBoxPotFry.UseVisualStyleBackColor = true;
            this.checkBoxPotFry.CheckedChanged += new System.EventHandler(this.checkBoxPotFry_CheckedChanged);
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Location = new System.Drawing.Point(15, 84);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBurger.TabIndex = 1;
            this.checkBoxBurger.Text = "Гамбургер";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.checkBoxBurger_CheckedChanged);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(15, 44);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(67, 17);
            this.checkBoxHotDog.TabIndex = 0;
            this.checkBoxHotDog.Text = "Хот Дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.pictureBox1);
            this.groupBoxTotal.Controls.Add(this.label1);
            this.groupBoxTotal.Controls.Add(this.labelSummAll);
            this.groupBoxTotal.Controls.Add(this.buttonSummAll);
            this.groupBoxTotal.Location = new System.Drawing.Point(24, 368);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(557, 94);
            this.groupBoxTotal.TabIndex = 2;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "ВСЕГО к оплате";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "грн.";
            // 
            // labelSummAll
            // 
            this.labelSummAll.AutoSize = true;
            this.labelSummAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSummAll.Location = new System.Drawing.Point(387, 41);
            this.labelSummAll.Name = "labelSummAll";
            this.labelSummAll.Size = new System.Drawing.Size(62, 29);
            this.labelSummAll.TabIndex = 1;
            this.labelSummAll.Text = "0,00";
            this.labelSummAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSummAll
            // 
            this.buttonSummAll.BackColor = System.Drawing.Color.Green;
            this.buttonSummAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSummAll.Location = new System.Drawing.Point(93, 31);
            this.buttonSummAll.Name = "buttonSummAll";
            this.buttonSummAll.Size = new System.Drawing.Size(157, 50);
            this.buttonSummAll.TabIndex = 0;
            this.buttonSummAll.Text = "РАССЧИТАТЬ";
            this.buttonSummAll.UseVisualStyleBackColor = false;
            // 
            // groupBoxTotalFuel
            // 
            this.groupBoxTotalFuel.Controls.Add(this.labelShowTotalFuel);
            this.groupBoxTotalFuel.Controls.Add(this.labelTotalQorSumm);
            this.groupBoxTotalFuel.Location = new System.Drawing.Point(24, 275);
            this.groupBoxTotalFuel.Name = "groupBoxTotalFuel";
            this.groupBoxTotalFuel.Size = new System.Drawing.Size(250, 78);
            this.groupBoxTotalFuel.TabIndex = 3;
            this.groupBoxTotalFuel.TabStop = false;
            this.groupBoxTotalFuel.Text = "К оплате";
            // 
            // labelShowTotalFuel
            // 
            this.labelShowTotalFuel.AutoSize = true;
            this.labelShowTotalFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowTotalFuel.Location = new System.Drawing.Point(96, 34);
            this.labelShowTotalFuel.Name = "labelShowTotalFuel";
            this.labelShowTotalFuel.Size = new System.Drawing.Size(62, 29);
            this.labelShowTotalFuel.TabIndex = 2;
            this.labelShowTotalFuel.Text = "0,00";
            this.labelShowTotalFuel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalQorSumm
            // 
            this.labelTotalQorSumm.AutoSize = true;
            this.labelTotalQorSumm.Location = new System.Drawing.Point(217, 46);
            this.labelTotalQorSumm.Name = "labelTotalQorSumm";
            this.labelTotalQorSumm.Size = new System.Drawing.Size(27, 13);
            this.labelTotalQorSumm.TabIndex = 1;
            this.labelTotalQorSumm.Text = "грн.";
            // 
            // groupBoxTotalCafe
            // 
            this.groupBoxTotalCafe.Controls.Add(this.labelTotalCafe);
            this.groupBoxTotalCafe.Controls.Add(this.labelTotalCafeSumm);
            this.groupBoxTotalCafe.Location = new System.Drawing.Point(291, 275);
            this.groupBoxTotalCafe.Name = "groupBoxTotalCafe";
            this.groupBoxTotalCafe.Size = new System.Drawing.Size(290, 78);
            this.groupBoxTotalCafe.TabIndex = 5;
            this.groupBoxTotalCafe.TabStop = false;
            this.groupBoxTotalCafe.Text = "К оплате";
            // 
            // labelTotalCafe
            // 
            this.labelTotalCafe.AutoSize = true;
            this.labelTotalCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCafe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalCafe.Location = new System.Drawing.Point(119, 33);
            this.labelTotalCafe.Name = "labelTotalCafe";
            this.labelTotalCafe.Size = new System.Drawing.Size(62, 29);
            this.labelTotalCafe.TabIndex = 1;
            this.labelTotalCafe.Text = "0,00";
            this.labelTotalCafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCafeSumm
            // 
            this.labelTotalCafeSumm.AutoSize = true;
            this.labelTotalCafeSumm.Location = new System.Drawing.Point(243, 45);
            this.labelTotalCafeSumm.Name = "labelTotalCafeSumm";
            this.labelTotalCafeSumm.Size = new System.Drawing.Size(27, 13);
            this.labelTotalCafeSumm.TabIndex = 0;
            this.labelTotalCafeSumm.Text = "грн.";
            // 
            // labelTOTALMONEY
            // 
            this.labelTOTALMONEY.AutoSize = true;
            this.labelTOTALMONEY.Location = new System.Drawing.Point(214, 11);
            this.labelTOTALMONEY.Name = "labelTOTALMONEY";
            this.labelTOTALMONEY.Size = new System.Drawing.Size(51, 13);
            this.labelTOTALMONEY.TabIndex = 6;
            this.labelTOTALMONEY.Text = "0,00 грн.";
            // 
            // labelTotalmoneyInfo
            // 
            this.labelTotalmoneyInfo.AutoEllipsis = true;
            this.labelTotalmoneyInfo.AutoSize = true;
            this.labelTotalmoneyInfo.Location = new System.Drawing.Point(24, 11);
            this.labelTotalmoneyInfo.Name = "labelTotalmoneyInfo";
            this.labelTotalmoneyInfo.Size = new System.Drawing.Size(109, 13);
            this.labelTotalmoneyInfo.TabIndex = 7;
            this.labelTotalmoneyInfo.Text = "Выручка за сегодня";
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Location = new System.Drawing.Point(294, 9);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(55, 13);
            this.labelClients.TabIndex = 8;
            this.labelClients.Text = "Клиентов";
            // 
            // labelClientsShow
            // 
            this.labelClientsShow.AutoSize = true;
            this.labelClientsShow.Location = new System.Drawing.Point(505, 9);
            this.labelClientsShow.Name = "labelClientsShow";
            this.labelClientsShow.Size = new System.Drawing.Size(36, 13);
            this.labelClientsShow.TabIndex = 9;
            this.labelClientsShow.Text = "0 чел.";
            // 
            // labelAvgCheck
            // 
            this.labelAvgCheck.AutoSize = true;
            this.labelAvgCheck.Location = new System.Drawing.Point(297, 38);
            this.labelAvgCheck.Name = "labelAvgCheck";
            this.labelAvgCheck.Size = new System.Drawing.Size(70, 13);
            this.labelAvgCheck.TabIndex = 10;
            this.labelAvgCheck.Text = "Средний чек";
            // 
            // labelAvgCheckShow
            // 
            this.labelAvgCheckShow.AutoSize = true;
            this.labelAvgCheckShow.Location = new System.Drawing.Point(490, 38);
            this.labelAvgCheckShow.Name = "labelAvgCheckShow";
            this.labelAvgCheckShow.Size = new System.Drawing.Size(51, 13);
            this.labelAvgCheckShow.TabIndex = 11;
            this.labelAvgCheckShow.Text = "0,00 грн.";
            this.labelAvgCheckShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 474);
            this.Controls.Add(this.labelAvgCheckShow);
            this.Controls.Add(this.labelAvgCheck);
            this.Controls.Add(this.labelClientsShow);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.labelTotalmoneyInfo);
            this.Controls.Add(this.labelTOTALMONEY);
            this.Controls.Add(this.groupBoxTotalCafe);
            this.Controls.Add(this.groupBoxTotalFuel);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxCafe);
            this.Controls.Add(this.groupBoxFuel);
            this.Name = "Form1";
            this.Text = "BESTOil";
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBoxFuelChoose.ResumeLayout(false);
            this.groupBoxFuelChoose.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.groupBoxCafe.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTotalFuel.ResumeLayout(false);
            this.groupBoxTotalFuel.PerformLayout();
            this.groupBoxTotalCafe.ResumeLayout(false);
            this.groupBoxTotalCafe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuel;
        private System.Windows.Forms.GroupBox groupBoxFuelChoose;
        private System.Windows.Forms.RadioButton radioButtonFuelSumm;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.ComboBox comboBoxFuelType;
        private System.Windows.Forms.Label labelFuelPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.GroupBox groupBoxCafe;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.Label labelLitre;
        private System.Windows.Forms.TextBox textBoxFuelSumm;
        private System.Windows.Forms.GroupBox groupBoxTotalFuel;
        private System.Windows.Forms.Label labelTotalQorSumm;
        private System.Windows.Forms.TextBox textBoxFuelQuantity;
        private System.Windows.Forms.Label labelColumnQuantity;
        private System.Windows.Forms.Label labelColumnPrice;
        private System.Windows.Forms.TextBox textBoxColaSumm;
        private System.Windows.Forms.TextBox textBoxPotatoSumm;
        private System.Windows.Forms.TextBox textBoxBurgerSumm;
        private System.Windows.Forms.TextBox textBoxDogSumm;
        private System.Windows.Forms.TextBox textBoxColaPrice;
        private System.Windows.Forms.TextBox textBoxPotatoPrice;
        private System.Windows.Forms.TextBox textBoxBurgerPrice;
        private System.Windows.Forms.TextBox textBoxDogPrice;
        private System.Windows.Forms.CheckBox checkBoxCola;
        private System.Windows.Forms.CheckBox checkBoxPotFry;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.GroupBox groupBoxTotalCafe;
        private System.Windows.Forms.Label labelShowTotalFuel;
        private System.Windows.Forms.Label labelTotalCafe;
        private System.Windows.Forms.Label labelTotalCafeSumm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSummAll;
        private System.Windows.Forms.Button buttonSummAll;
        private System.Windows.Forms.Label labelTOTALMONEY;
        private System.Windows.Forms.Label labelTotalmoneyInfo;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelClientsShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAvgCheck;
        private System.Windows.Forms.Label labelAvgCheckShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

