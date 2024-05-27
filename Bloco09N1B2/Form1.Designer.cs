namespace Bloco09N1B12B
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_consulta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.grp_filtrar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cod_sap = new System.Windows.Forms.ComboBox();
            this.num_patrimonio = new System.Windows.Forms.ComboBox();
            this.cod_status = new System.Windows.Forms.ComboBox();
            this.cod_local = new System.Windows.Forms.ComboBox();
            this.serialNum = new System.Windows.Forms.ComboBox();
            this.cod_descr = new System.Windows.Forms.ComboBox();
            this.cod_modelo = new System.Windows.Forms.ComboBox();
            this.cod_marca = new System.Windows.Forms.ComboBox();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grp_adicionar_deletar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_filtrar.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grp_adicionar_deletar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_atualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grp_filtrar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grp_adicionar_deletar, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.lv_consulta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1277, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Equipamentos";
            // 
            // lv_consulta
            // 
            this.lv_consulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_consulta.HideSelection = false;
            this.lv_consulta.Location = new System.Drawing.Point(3, 28);
            this.lv_consulta.Name = "lv_consulta";
            this.lv_consulta.Size = new System.Drawing.Size(1271, 258);
            this.lv_consulta.TabIndex = 0;
            this.lv_consulta.UseCompatibleStateImageBehavior = false;
            this.lv_consulta.View = System.Windows.Forms.View.Details;
            this.lv_consulta.SelectedIndexChanged += new System.EventHandler(this.lv_consulta_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Equipamento";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marca";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descrição";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Num Patrimonio";
            this.columnHeader8.Width = 165;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Codigo";
            this.columnHeader5.Width = 165;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cod Sap";
            this.columnHeader9.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Local";
            this.columnHeader6.Width = 165;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 165;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.SetColumnSpan(this.bt_atualizar, 2);
            this.bt_atualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_atualizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.Location = new System.Drawing.Point(3, 298);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(1277, 44);
            this.bt_atualizar.TabIndex = 1;
            this.bt_atualizar.Text = "Atualizar Lista";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // grp_filtrar
            // 
            this.grp_filtrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grp_filtrar.Controls.Add(this.tableLayoutPanel3);
            this.grp_filtrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_filtrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_filtrar.Location = new System.Drawing.Point(3, 348);
            this.grp_filtrar.Name = "grp_filtrar";
            this.grp_filtrar.Size = new System.Drawing.Size(635, 291);
            this.grp_filtrar.TabIndex = 2;
            this.grp_filtrar.TabStop = false;
            this.grp_filtrar.Text = "Filtrar";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.cod_sap, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.num_patrimonio, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cod_status, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.cod_local, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.serialNum, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cod_descr, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cod_modelo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cod_marca, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_filtrar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(629, 260);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cod_sap
            // 
            this.cod_sap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_sap.FormattingEnabled = true;
            this.cod_sap.Location = new System.Drawing.Point(212, 163);
            this.cod_sap.Name = "cod_sap";
            this.cod_sap.Size = new System.Drawing.Size(203, 32);
            this.cod_sap.TabIndex = 18;
            this.cod_sap.DropDown += new System.EventHandler(this.cod_sap_DropDown);
            // 
            // num_patrimonio
            // 
            this.num_patrimonio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_patrimonio.FormattingEnabled = true;
            this.num_patrimonio.Location = new System.Drawing.Point(212, 99);
            this.num_patrimonio.Name = "num_patrimonio";
            this.num_patrimonio.Size = new System.Drawing.Size(203, 32);
            this.num_patrimonio.TabIndex = 16;
            this.num_patrimonio.DropDown += new System.EventHandler(this.num_patrimonio_DropDown);
            // 
            // cod_status
            // 
            this.cod_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_status.FormattingEnabled = true;
            this.cod_status.Location = new System.Drawing.Point(212, 227);
            this.cod_status.Name = "cod_status";
            this.cod_status.Size = new System.Drawing.Size(203, 32);
            this.cod_status.TabIndex = 14;
            this.cod_status.DropDown += new System.EventHandler(this.cod_status_DropDown);
            // 
            // cod_local
            // 
            this.cod_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_local.FormattingEnabled = true;
            this.cod_local.Location = new System.Drawing.Point(212, 195);
            this.cod_local.Name = "cod_local";
            this.cod_local.Size = new System.Drawing.Size(203, 32);
            this.cod_local.TabIndex = 13;
            this.cod_local.DropDown += new System.EventHandler(this.cod_local_DropDown);
            // 
            // serialNum
            // 
            this.serialNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialNum.FormattingEnabled = true;
            this.serialNum.Location = new System.Drawing.Point(212, 131);
            this.serialNum.Name = "serialNum";
            this.serialNum.Size = new System.Drawing.Size(203, 32);
            this.serialNum.TabIndex = 12;
            this.serialNum.DropDown += new System.EventHandler(this.serialNum_DropDown);
            // 
            // cod_descr
            // 
            this.cod_descr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_descr.FormattingEnabled = true;
            this.cod_descr.Location = new System.Drawing.Point(212, 67);
            this.cod_descr.Name = "cod_descr";
            this.cod_descr.Size = new System.Drawing.Size(203, 32);
            this.cod_descr.TabIndex = 11;
            this.cod_descr.DropDown += new System.EventHandler(this.cod_descr_DropDown);
            // 
            // cod_modelo
            // 
            this.cod_modelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_modelo.FormattingEnabled = true;
            this.cod_modelo.Location = new System.Drawing.Point(212, 35);
            this.cod_modelo.Name = "cod_modelo";
            this.cod_modelo.Size = new System.Drawing.Size(203, 32);
            this.cod_modelo.TabIndex = 10;
            this.cod_modelo.DropDown += new System.EventHandler(this.cod_modelo_DropDown);
            // 
            // cod_marca
            // 
            this.cod_marca.DisplayMember = "1";
            this.cod_marca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cod_marca.FormattingEnabled = true;
            this.cod_marca.Location = new System.Drawing.Point(212, 3);
            this.cod_marca.Name = "cod_marca";
            this.cod_marca.Size = new System.Drawing.Size(203, 32);
            this.cod_marca.TabIndex = 9;
            this.cod_marca.ValueMember = "1";
            this.cod_marca.DropDown += new System.EventHandler(this.cod_marca_DropDown);
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.BackColor = System.Drawing.Color.PeachPuff;
            this.bt_filtrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_filtrar.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filtrar.Location = new System.Drawing.Point(421, 3);
            this.bt_filtrar.Name = "bt_filtrar";
            this.tableLayoutPanel3.SetRowSpan(this.bt_filtrar, 8);
            this.bt_filtrar.Size = new System.Drawing.Size(205, 254);
            this.bt_filtrar.TabIndex = 0;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = false;
            this.bt_filtrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Local";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Num Patrimonio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cod Sap";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_adicionar_deletar
            // 
            this.grp_adicionar_deletar.Controls.Add(this.tableLayoutPanel2);
            this.grp_adicionar_deletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_adicionar_deletar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_adicionar_deletar.Location = new System.Drawing.Point(644, 348);
            this.grp_adicionar_deletar.Name = "grp_adicionar_deletar";
            this.grp_adicionar_deletar.Size = new System.Drawing.Size(636, 291);
            this.grp_adicionar_deletar.TabIndex = 3;
            this.grp_adicionar_deletar.TabStop = false;
            this.grp_adicionar_deletar.Text = "Adicionar e Deletar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bt_adicionar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_deletar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 260);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.BackColor = System.Drawing.Color.LightGreen;
            this.bt_adicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_adicionar.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adicionar.Location = new System.Drawing.Point(3, 3);
            this.bt_adicionar.Name = "bt_adicionar";
            this.tableLayoutPanel2.SetRowSpan(this.bt_adicionar, 2);
            this.bt_adicionar.Size = new System.Drawing.Size(309, 254);
            this.bt_adicionar.TabIndex = 0;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = false;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.BackColor = System.Drawing.Color.Brown;
            this.bt_deletar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_deletar.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deletar.Location = new System.Drawing.Point(318, 3);
            this.bt_deletar.Name = "bt_deletar";
            this.tableLayoutPanel2.SetRowSpan(this.bt_deletar, 2);
            this.bt_deletar.Size = new System.Drawing.Size(309, 254);
            this.bt_deletar.TabIndex = 1;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grp_filtrar.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grp_adicionar_deletar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.ListView lv_consulta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox grp_filtrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grp_adicionar_deletar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cod_status;
        private System.Windows.Forms.ComboBox cod_local;
        private System.Windows.Forms.ComboBox serialNum;
        private System.Windows.Forms.ComboBox cod_descr;
        private System.Windows.Forms.ComboBox cod_modelo;
        private System.Windows.Forms.ComboBox cod_marca;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox num_patrimonio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cod_sap;
        private System.Windows.Forms.Label label8;
    }
}

