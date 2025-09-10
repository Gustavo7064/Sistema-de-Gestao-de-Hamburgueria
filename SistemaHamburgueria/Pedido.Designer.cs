namespace SistemaHamburgueria
{
    partial class Pedido
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorLanche = new System.Windows.Forms.TextBox();
            this.grpRetirar = new System.Windows.Forms.GroupBox();
            this.chkTomate = new System.Windows.Forms.CheckBox();
            this.chkBaconR = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkSalada = new System.Windows.Forms.CheckBox();
            this.lblValorLanche = new System.Windows.Forms.Label();
            this.cmbLanches = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkQueijo = new System.Windows.Forms.CheckBox();
            this.chkMolho = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkFrango = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.chkHabmburguer = new System.Windows.Forms.CheckBox();
            this.chkCatupiryA = new System.Windows.Forms.CheckBox();
            this.chkMolhoEspecial = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkMaionese = new System.Windows.Forms.CheckBox();
            this.grpAdicionar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAcompanhamentos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.grpRetirar.SuspendLayout();
            this.grpAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(812, 222);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(812, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 40);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(905, 106);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 28;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(732, 106);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(133, 20);
            this.txtValorOpcionais.TabIndex = 27;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(902, 73);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 26;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(735, 73);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 25;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorLanche
            // 
            this.txtValorLanche.Location = new System.Drawing.Point(575, 105);
            this.txtValorLanche.Name = "txtValorLanche";
            this.txtValorLanche.Size = new System.Drawing.Size(123, 20);
            this.txtValorLanche.TabIndex = 24;
            // 
            // grpRetirar
            // 
            this.grpRetirar.Controls.Add(this.chkFrango);
            this.grpRetirar.Controls.Add(this.chkMolho);
            this.grpRetirar.Controls.Add(this.chkQueijo);
            this.grpRetirar.Controls.Add(this.chkCarne);
            this.grpRetirar.Controls.Add(this.chkTomate);
            this.grpRetirar.Controls.Add(this.chkBaconR);
            this.grpRetirar.Controls.Add(this.chkCebola);
            this.grpRetirar.Controls.Add(this.chkSalada);
            this.grpRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRetirar.Location = new System.Drawing.Point(286, 259);
            this.grpRetirar.Name = "grpRetirar";
            this.grpRetirar.Size = new System.Drawing.Size(222, 150);
            this.grpRetirar.TabIndex = 23;
            this.grpRetirar.TabStop = false;
            this.grpRetirar.Text = "Deseja retirar algum incremento:";
            this.grpRetirar.Enter += new System.EventHandler(this.grpRetirar_Enter);
            // 
            // chkTomate
            // 
            this.chkTomate.AutoSize = true;
            this.chkTomate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomate.Location = new System.Drawing.Point(6, 119);
            this.chkTomate.Name = "chkTomate";
            this.chkTomate.Size = new System.Drawing.Size(66, 16);
            this.chkTomate.TabIndex = 4;
            this.chkTomate.Text = "Tomate";
            this.chkTomate.UseVisualStyleBackColor = true;
            // 
            // chkBaconR
            // 
            this.chkBaconR.AutoSize = true;
            this.chkBaconR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBaconR.Location = new System.Drawing.Point(6, 94);
            this.chkBaconR.Name = "chkBaconR";
            this.chkBaconR.Size = new System.Drawing.Size(60, 16);
            this.chkBaconR.TabIndex = 3;
            this.chkBaconR.Text = "Bacon";
            this.chkBaconR.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCebola.Location = new System.Drawing.Point(6, 72);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(66, 16);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola ";
            this.chkCebola.UseVisualStyleBackColor = true;
            this.chkCebola.CheckedChanged += new System.EventHandler(this.chkCebola_CheckedChanged);
            // 
            // chkSalada
            // 
            this.chkSalada.AutoSize = true;
            this.chkSalada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalada.Location = new System.Drawing.Point(6, 47);
            this.chkSalada.Name = "chkSalada";
            this.chkSalada.Size = new System.Drawing.Size(62, 16);
            this.chkSalada.TabIndex = 1;
            this.chkSalada.Text = "Salada";
            this.chkSalada.UseVisualStyleBackColor = true;
            this.chkSalada.CheckedChanged += new System.EventHandler(this.chkSalada_CheckedChanged);
            // 
            // lblValorLanche
            // 
            this.lblValorLanche.AutoSize = true;
            this.lblValorLanche.Location = new System.Drawing.Point(583, 73);
            this.lblValorLanche.Name = "lblValorLanche";
            this.lblValorLanche.Size = new System.Drawing.Size(108, 13);
            this.lblValorLanche.TabIndex = 22;
            this.lblValorLanche.Text = "VALOR DO LANCHE";
            // 
            // cmbLanches
            // 
            this.cmbLanches.FormattingEnabled = true;
            this.cmbLanches.Location = new System.Drawing.Point(37, 65);
            this.cmbLanches.Name = "cmbLanches";
            this.cmbLanches.Size = new System.Drawing.Size(200, 21);
            this.cmbLanches.TabIndex = 20;
            this.cmbLanches.Text = "                         Opções";
            this.cmbLanches.SelectedIndexChanged += new System.EventHandler(this.cmbLanches_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(671, 222);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 40);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            this.chkCarne.AutoSize = true;
            this.chkCarne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarne.Location = new System.Drawing.Point(111, 119);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(58, 16);
            this.chkCarne.TabIndex = 5;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            this.chkQueijo.AutoSize = true;
            this.chkQueijo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQueijo.Location = new System.Drawing.Point(111, 47);
            this.chkQueijo.Name = "chkQueijo";
            this.chkQueijo.Size = new System.Drawing.Size(60, 16);
            this.chkQueijo.TabIndex = 6;
            this.chkQueijo.Text = "Queijo";
            this.chkQueijo.UseVisualStyleBackColor = true;
            // 
            // chkMolho
            // 
            this.chkMolho.AutoSize = true;
            this.chkMolho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMolho.Location = new System.Drawing.Point(111, 69);
            this.chkMolho.Name = "chkMolho";
            this.chkMolho.Size = new System.Drawing.Size(57, 16);
            this.chkMolho.TabIndex = 7;
            this.chkMolho.Text = "Molho";
            this.chkMolho.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(586, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(197, 40);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // chkFrango
            // 
            this.chkFrango.AutoSize = true;
            this.chkFrango.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFrango.Location = new System.Drawing.Point(111, 94);
            this.chkFrango.Name = "chkFrango";
            this.chkFrango.Size = new System.Drawing.Size(64, 16);
            this.chkFrango.TabIndex = 8;
            this.chkFrango.Text = "Frango";
            this.chkFrango.UseVisualStyleBackColor = true;
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheddar.Location = new System.Drawing.Point(16, 19);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(125, 16);
            this.chkCheddar.TabIndex = 1;
            this.chkCheddar.Text = "Cheddar (R$ 6,00)";
            this.chkCheddar.UseVisualStyleBackColor = true;
            this.chkCheddar.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkHabmburguer
            // 
            this.chkHabmburguer.AutoSize = true;
            this.chkHabmburguer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabmburguer.Location = new System.Drawing.Point(16, 42);
            this.chkHabmburguer.Name = "chkHabmburguer";
            this.chkHabmburguer.Size = new System.Drawing.Size(186, 16);
            this.chkHabmburguer.TabIndex = 2;
            this.chkHabmburguer.Text = "Hamburguer extra (R$ 12,00)";
            this.chkHabmburguer.UseVisualStyleBackColor = true;
            this.chkHabmburguer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkCatupiryA
            // 
            this.chkCatupiryA.AutoSize = true;
            this.chkCatupiryA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCatupiryA.Location = new System.Drawing.Point(16, 65);
            this.chkCatupiryA.Name = "chkCatupiryA";
            this.chkCatupiryA.Size = new System.Drawing.Size(127, 16);
            this.chkCatupiryA.TabIndex = 3;
            this.chkCatupiryA.Text = "Catupiry  (R$ 8,00)";
            this.chkCatupiryA.UseVisualStyleBackColor = true;
            this.chkCatupiryA.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkMolhoEspecial
            // 
            this.chkMolhoEspecial.AutoSize = true;
            this.chkMolhoEspecial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMolhoEspecial.Location = new System.Drawing.Point(16, 88);
            this.chkMolhoEspecial.Name = "chkMolhoEspecial";
            this.chkMolhoEspecial.Size = new System.Drawing.Size(160, 16);
            this.chkMolhoEspecial.TabIndex = 4;
            this.chkMolhoEspecial.Text = "Molho especial (R$ 3,00)";
            this.chkMolhoEspecial.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.Location = new System.Drawing.Point(16, 111);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(113, 16);
            this.chkBacon.TabIndex = 36;
            this.chkBacon.Text = "Bacon (R$ 5,00)";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkMaionese
            // 
            this.chkMaionese.AutoSize = true;
            this.chkMaionese.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaionese.Location = new System.Drawing.Point(16, 134);
            this.chkMaionese.Name = "chkMaionese";
            this.chkMaionese.Size = new System.Drawing.Size(130, 16);
            this.chkMaionese.TabIndex = 37;
            this.chkMaionese.Text = "Maionese (R$ 3,00)";
            this.chkMaionese.UseVisualStyleBackColor = true;
            this.chkMaionese.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // grpAdicionar
            // 
            this.grpAdicionar.Controls.Add(this.chkMaionese);
            this.grpAdicionar.Controls.Add(this.chkBacon);
            this.grpAdicionar.Controls.Add(this.chkMolhoEspecial);
            this.grpAdicionar.Controls.Add(this.chkCatupiryA);
            this.grpAdicionar.Controls.Add(this.chkHabmburguer);
            this.grpAdicionar.Controls.Add(this.chkCheddar);
            this.grpAdicionar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdicionar.Location = new System.Drawing.Point(286, 65);
            this.grpAdicionar.Name = "grpAdicionar";
            this.grpAdicionar.Size = new System.Drawing.Size(222, 150);
            this.grpAdicionar.TabIndex = 24;
            this.grpAdicionar.TabStop = false;
            this.grpAdicionar.Text = "Adicionais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "LANCHES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ACOMPANHAMENTOS";
            // 
            // cmbAcompanhamentos
            // 
            this.cmbAcompanhamentos.FormattingEnabled = true;
            this.cmbAcompanhamentos.Location = new System.Drawing.Point(37, 207);
            this.cmbAcompanhamentos.Name = "cmbAcompanhamentos";
            this.cmbAcompanhamentos.Size = new System.Drawing.Size(200, 21);
            this.cmbAcompanhamentos.TabIndex = 33;
            this.cmbAcompanhamentos.Text = "                         Opções";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "BEBIDAS";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(37, 364);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(200, 21);
            this.cmbBebidas.TabIndex = 35;
            this.cmbBebidas.Text = "                         Opções";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAcompanhamentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorLanche);
            this.Controls.Add(this.grpRetirar);
            this.Controls.Add(this.lblValorLanche);
            this.Controls.Add(this.cmbLanches);
            this.Controls.Add(this.btnMenu);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.grpRetirar.ResumeLayout(false);
            this.grpRetirar.PerformLayout();
            this.grpAdicionar.ResumeLayout(false);
            this.grpAdicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorLanche;
        private System.Windows.Forms.GroupBox grpRetirar;
        private System.Windows.Forms.CheckBox chkTomate;
        private System.Windows.Forms.CheckBox chkBaconR;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkSalada;
        private System.Windows.Forms.Label lblValorLanche;
        private System.Windows.Forms.ComboBox cmbLanches;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.CheckBox chkQueijo;
        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkMolho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkFrango;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.CheckBox chkHabmburguer;
        private System.Windows.Forms.CheckBox chkCatupiryA;
        private System.Windows.Forms.CheckBox chkMolhoEspecial;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkMaionese;
        private System.Windows.Forms.GroupBox grpAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAcompanhamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBebidas;
    }
}