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
            this.grpAdicionar = new System.Windows.Forms.GroupBox();
            this.chkMolhoEspecial = new System.Windows.Forms.CheckBox();
            this.chkCatupiryA = new System.Windows.Forms.CheckBox();
            this.chkHabmburguer = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkQueijo = new System.Windows.Forms.CheckBox();
            this.chkMolho = new System.Windows.Forms.CheckBox();
            this.chkMaionese = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkFrango = new System.Windows.Forms.CheckBox();
            this.grpRetirar.SuspendLayout();
            this.grpAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(611, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(334, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 40);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(611, 88);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 28;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(454, 88);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 27;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(618, 63);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 26;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(437, 63);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 25;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorLanche
            // 
            this.txtValorLanche.Location = new System.Drawing.Point(302, 88);
            this.txtValorLanche.Name = "txtValorLanche";
            this.txtValorLanche.Size = new System.Drawing.Size(100, 20);
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
            this.grpRetirar.Location = new System.Drawing.Point(54, 267);
            this.grpRetirar.Name = "grpRetirar";
            this.grpRetirar.Size = new System.Drawing.Size(200, 150);
            this.grpRetirar.TabIndex = 23;
            this.grpRetirar.TabStop = false;
            this.grpRetirar.Text = "Deseja retirar algum incremento:";
            // 
            // chkTomate
            // 
            this.chkTomate.AutoSize = true;
            this.chkTomate.Location = new System.Drawing.Point(6, 88);
            this.chkTomate.Name = "chkTomate";
            this.chkTomate.Size = new System.Drawing.Size(62, 17);
            this.chkTomate.TabIndex = 4;
            this.chkTomate.Text = "Tomate";
            this.chkTomate.UseVisualStyleBackColor = true;
            // 
            // chkBaconR
            // 
            this.chkBaconR.AutoSize = true;
            this.chkBaconR.Location = new System.Drawing.Point(6, 65);
            this.chkBaconR.Name = "chkBaconR";
            this.chkBaconR.Size = new System.Drawing.Size(57, 17);
            this.chkBaconR.TabIndex = 3;
            this.chkBaconR.Text = "Bacon";
            this.chkBaconR.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 42);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(62, 17);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola ";
            this.chkCebola.UseVisualStyleBackColor = true;
            this.chkCebola.CheckedChanged += new System.EventHandler(this.chkCebola_CheckedChanged);
            // 
            // chkSalada
            // 
            this.chkSalada.AutoSize = true;
            this.chkSalada.Location = new System.Drawing.Point(6, 19);
            this.chkSalada.Name = "chkSalada";
            this.chkSalada.Size = new System.Drawing.Size(59, 17);
            this.chkSalada.TabIndex = 1;
            this.chkSalada.Text = "Salada";
            this.chkSalada.UseVisualStyleBackColor = true;
            // 
            // lblValorLanche
            // 
            this.lblValorLanche.AutoSize = true;
            this.lblValorLanche.Location = new System.Drawing.Point(299, 63);
            this.lblValorLanche.Name = "lblValorLanche";
            this.lblValorLanche.Size = new System.Drawing.Size(108, 13);
            this.lblValorLanche.TabIndex = 22;
            this.lblValorLanche.Text = "VALOR DO LANCHE";
            // 
            // cmbLanches
            // 
            this.cmbLanches.FormattingEnabled = true;
            this.cmbLanches.Items.AddRange(new object[] {
            "X-SALADA",
            "X-BACON",
            "COMBO DUPPLO SALADA",
            "X-FRANGO JUNIOR",
            "X-FRANGO MEDIO",
            "CHEDDAR DUPLO "});
            this.cmbLanches.Location = new System.Drawing.Point(54, 41);
            this.cmbLanches.Name = "cmbLanches";
            this.cmbLanches.Size = new System.Drawing.Size(200, 21);
            this.cmbLanches.TabIndex = 20;
            this.cmbLanches.Text = "Opções";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(472, 309);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 40);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // grpAdicionar
            // 
            this.grpAdicionar.Controls.Add(this.chkMaionese);
            this.grpAdicionar.Controls.Add(this.chkBacon);
            this.grpAdicionar.Controls.Add(this.chkMolhoEspecial);
            this.grpAdicionar.Controls.Add(this.chkCatupiryA);
            this.grpAdicionar.Controls.Add(this.chkHabmburguer);
            this.grpAdicionar.Controls.Add(this.chkCheddar);
            this.grpAdicionar.Location = new System.Drawing.Point(54, 100);
            this.grpAdicionar.Name = "grpAdicionar";
            this.grpAdicionar.Size = new System.Drawing.Size(200, 150);
            this.grpAdicionar.TabIndex = 24;
            this.grpAdicionar.TabStop = false;
            this.grpAdicionar.Text = "Adicionais";
            // 
            // chkMolhoEspecial
            // 
            this.chkMolhoEspecial.AutoSize = true;
            this.chkMolhoEspecial.Location = new System.Drawing.Point(6, 88);
            this.chkMolhoEspecial.Name = "chkMolhoEspecial";
            this.chkMolhoEspecial.Size = new System.Drawing.Size(144, 17);
            this.chkMolhoEspecial.TabIndex = 4;
            this.chkMolhoEspecial.Text = "Molho especial (R$ 3,00)";
            this.chkMolhoEspecial.UseVisualStyleBackColor = true;
            // 
            // chkCatupiryA
            // 
            this.chkCatupiryA.AutoSize = true;
            this.chkCatupiryA.Location = new System.Drawing.Point(6, 65);
            this.chkCatupiryA.Name = "chkCatupiryA";
            this.chkCatupiryA.Size = new System.Drawing.Size(114, 17);
            this.chkCatupiryA.TabIndex = 3;
            this.chkCatupiryA.Text = "Catupiry  (R$ 8,00)";
            this.chkCatupiryA.UseVisualStyleBackColor = true;
            this.chkCatupiryA.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkHabmburguer
            // 
            this.chkHabmburguer.AutoSize = true;
            this.chkHabmburguer.Location = new System.Drawing.Point(6, 42);
            this.chkHabmburguer.Name = "chkHabmburguer";
            this.chkHabmburguer.Size = new System.Drawing.Size(163, 17);
            this.chkHabmburguer.TabIndex = 2;
            this.chkHabmburguer.Text = "Hamburguer extra (R$ 12,00)";
            this.chkHabmburguer.UseVisualStyleBackColor = true;
            this.chkHabmburguer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Location = new System.Drawing.Point(6, 19);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(113, 17);
            this.chkCheddar.TabIndex = 1;
            this.chkCheddar.Text = "Cheddar (R$ 6,00)";
            this.chkCheddar.UseVisualStyleBackColor = true;
            this.chkCheddar.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 111);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(104, 17);
            this.chkBacon.TabIndex = 36;
            this.chkBacon.Text = "Bacon (R$ 5,00)";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            this.chkCarne.AutoSize = true;
            this.chkCarne.Location = new System.Drawing.Point(6, 111);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(54, 17);
            this.chkCarne.TabIndex = 5;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            this.chkQueijo.AutoSize = true;
            this.chkQueijo.Location = new System.Drawing.Point(86, 19);
            this.chkQueijo.Name = "chkQueijo";
            this.chkQueijo.Size = new System.Drawing.Size(56, 17);
            this.chkQueijo.TabIndex = 6;
            this.chkQueijo.Text = "Queijo";
            this.chkQueijo.UseVisualStyleBackColor = true;
            // 
            // chkMolho
            // 
            this.chkMolho.AutoSize = true;
            this.chkMolho.Location = new System.Drawing.Point(86, 42);
            this.chkMolho.Name = "chkMolho";
            this.chkMolho.Size = new System.Drawing.Size(55, 17);
            this.chkMolho.TabIndex = 7;
            this.chkMolho.Text = "Molho";
            this.chkMolho.UseVisualStyleBackColor = true;
            // 
            // chkMaionese
            // 
            this.chkMaionese.AutoSize = true;
            this.chkMaionese.Location = new System.Drawing.Point(6, 134);
            this.chkMaionese.Name = "chkMaionese";
            this.chkMaionese.Size = new System.Drawing.Size(119, 17);
            this.chkMaionese.TabIndex = 37;
            this.chkMaionese.Text = "Maionese (R$ 3,00)";
            this.chkMaionese.UseVisualStyleBackColor = true;
            this.chkMaionese.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(364, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(283, 40);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // chkFrango
            // 
            this.chkFrango.AutoSize = true;
            this.chkFrango.Location = new System.Drawing.Point(86, 65);
            this.chkFrango.Name = "chkFrango";
            this.chkFrango.Size = new System.Drawing.Size(59, 17);
            this.chkFrango.TabIndex = 8;
            this.chkFrango.Text = "Frango";
            this.chkFrango.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.GroupBox grpAdicionar;
        private System.Windows.Forms.CheckBox chkMolhoEspecial;
        private System.Windows.Forms.CheckBox chkCatupiryA;
        private System.Windows.Forms.CheckBox chkHabmburguer;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkQueijo;
        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkMolho;
        private System.Windows.Forms.CheckBox chkMaionese;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkFrango;
    }
}