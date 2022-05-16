namespace Sistema_de_Votação
{
    partial class frmVotacao
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
            System.Windows.Forms.Label pafuncioLabel;
            System.Windows.Forms.Label fudêncioLabel;
            System.Windows.Forms.Label nuloLabel;
            System.Windows.Forms.Label brancoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVotacao));
            this.urna612DataSet = new Sistema_de_Votação.Urna612DataSet();
            this.urna666BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urna666TableAdapter = new Sistema_de_Votação.Urna612DataSetTableAdapters.Urna666TableAdapter();
            this.tableAdapterManager = new Sistema_de_Votação.Urna612DataSetTableAdapters.TableAdapterManager();
            this.urna666BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pafuncioRadioButton = new System.Windows.Forms.RadioButton();
            this.fudêncioRadioButton = new System.Windows.Forms.RadioButton();
            this.nuloRadioButton = new System.Windows.Forms.RadioButton();
            this.brancoRadioButton = new System.Windows.Forms.RadioButton();
            this.gbVoto = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.urna666BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblIniciarVotacao = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblConcluir = new System.Windows.Forms.Label();
            pafuncioLabel = new System.Windows.Forms.Label();
            fudêncioLabel = new System.Windows.Forms.Label();
            nuloLabel = new System.Windows.Forms.Label();
            brancoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urna612DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urna666BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urna666BindingNavigator)).BeginInit();
            this.urna666BindingNavigator.SuspendLayout();
            this.gbVoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // urna612DataSet
            // 
            this.urna612DataSet.DataSetName = "Urna612DataSet";
            this.urna612DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urna666BindingSource
            // 
            this.urna666BindingSource.DataMember = "Urna666";
            this.urna666BindingSource.DataSource = this.urna612DataSet;
            // 
            // urna666TableAdapter
            // 
            this.urna666TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Votação.Urna612DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Urna666TableAdapter = this.urna666TableAdapter;
            // 
            // urna666BindingNavigator
            // 
            this.urna666BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.urna666BindingNavigator.BindingSource = this.urna666BindingSource;
            this.urna666BindingNavigator.CountItem = null;
            this.urna666BindingNavigator.DeleteItem = null;
            this.urna666BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.urna666BindingNavigator.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urna666BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.urna666BindingNavigatorSaveItem});
            this.urna666BindingNavigator.Location = new System.Drawing.Point(225, 78);
            this.urna666BindingNavigator.MoveFirstItem = null;
            this.urna666BindingNavigator.MoveLastItem = null;
            this.urna666BindingNavigator.MoveNextItem = null;
            this.urna666BindingNavigator.MovePreviousItem = null;
            this.urna666BindingNavigator.Name = "urna666BindingNavigator";
            this.urna666BindingNavigator.PositionItem = null;
            this.urna666BindingNavigator.Size = new System.Drawing.Size(615, 52);
            this.urna666BindingNavigator.TabIndex = 0;
            this.urna666BindingNavigator.Text = "bindingNavigator1";
            // 
            // pafuncioLabel
            // 
            pafuncioLabel.AutoSize = true;
            pafuncioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pafuncioLabel.Location = new System.Drawing.Point(6, 22);
            pafuncioLabel.Name = "pafuncioLabel";
            pafuncioLabel.Size = new System.Drawing.Size(97, 24);
            pafuncioLabel.TabIndex = 3;
            pafuncioLabel.Text = "Pafuncio:";
            // 
            // pafuncioRadioButton
            // 
            this.pafuncioRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.urna666BindingSource, "Pafuncio", true));
            this.pafuncioRadioButton.Location = new System.Drawing.Point(109, 24);
            this.pafuncioRadioButton.Name = "pafuncioRadioButton";
            this.pafuncioRadioButton.Size = new System.Drawing.Size(35, 24);
            this.pafuncioRadioButton.TabIndex = 4;
            this.pafuncioRadioButton.TabStop = true;
            this.pafuncioRadioButton.UseVisualStyleBackColor = true;
            // 
            // fudêncioLabel
            // 
            fudêncioLabel.AutoSize = true;
            fudêncioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fudêncioLabel.Location = new System.Drawing.Point(429, 22);
            fudêncioLabel.Name = "fudêncioLabel";
            fudêncioLabel.Size = new System.Drawing.Size(105, 24);
            fudêncioLabel.TabIndex = 5;
            fudêncioLabel.Text = "Fudêncio:";
            // 
            // fudêncioRadioButton
            // 
            this.fudêncioRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.urna666BindingSource, "Fudêncio", true));
            this.fudêncioRadioButton.Location = new System.Drawing.Point(540, 24);
            this.fudêncioRadioButton.Name = "fudêncioRadioButton";
            this.fudêncioRadioButton.Size = new System.Drawing.Size(24, 24);
            this.fudêncioRadioButton.TabIndex = 6;
            this.fudêncioRadioButton.TabStop = true;
            this.fudêncioRadioButton.UseVisualStyleBackColor = true;
            // 
            // nuloLabel
            // 
            nuloLabel.AutoSize = true;
            nuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nuloLabel.Location = new System.Drawing.Point(6, 249);
            nuloLabel.Name = "nuloLabel";
            nuloLabel.Size = new System.Drawing.Size(60, 24);
            nuloLabel.TabIndex = 7;
            nuloLabel.Text = "Nulo:";
            // 
            // nuloRadioButton
            // 
            this.nuloRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.urna666BindingSource, "Nulo", true));
            this.nuloRadioButton.Location = new System.Drawing.Point(72, 251);
            this.nuloRadioButton.Name = "nuloRadioButton";
            this.nuloRadioButton.Size = new System.Drawing.Size(24, 24);
            this.nuloRadioButton.TabIndex = 8;
            this.nuloRadioButton.TabStop = true;
            this.nuloRadioButton.UseVisualStyleBackColor = true;
            // 
            // brancoLabel
            // 
            brancoLabel.AutoSize = true;
            brancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brancoLabel.Location = new System.Drawing.Point(439, 244);
            brancoLabel.Name = "brancoLabel";
            brancoLabel.Size = new System.Drawing.Size(82, 24);
            brancoLabel.TabIndex = 9;
            brancoLabel.Text = "Branco:";
            // 
            // brancoRadioButton
            // 
            this.brancoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.urna666BindingSource, "Branco", true));
            this.brancoRadioButton.Location = new System.Drawing.Point(527, 246);
            this.brancoRadioButton.Name = "brancoRadioButton";
            this.brancoRadioButton.Size = new System.Drawing.Size(24, 24);
            this.brancoRadioButton.TabIndex = 10;
            this.brancoRadioButton.TabStop = true;
            this.brancoRadioButton.UseVisualStyleBackColor = true;
            // 
            // gbVoto
            // 
            this.gbVoto.Controls.Add(this.pictureBox3);
            this.gbVoto.Controls.Add(this.pictureBox2);
            this.gbVoto.Controls.Add(this.pictureBox1);
            this.gbVoto.Controls.Add(pafuncioLabel);
            this.gbVoto.Controls.Add(this.brancoRadioButton);
            this.gbVoto.Controls.Add(this.pafuncioRadioButton);
            this.gbVoto.Controls.Add(brancoLabel);
            this.gbVoto.Controls.Add(fudêncioLabel);
            this.gbVoto.Controls.Add(this.nuloRadioButton);
            this.gbVoto.Controls.Add(this.fudêncioRadioButton);
            this.gbVoto.Controls.Add(nuloLabel);
            this.gbVoto.Controls.Add(this.pictureBox5);
            this.gbVoto.Controls.Add(this.pictureBox4);
            this.gbVoto.Location = new System.Drawing.Point(225, 159);
            this.gbVoto.Name = "gbVoto";
            this.gbVoto.Size = new System.Drawing.Size(584, 417);
            this.gbVoto.TabIndex = 11;
            this.gbVoto.TabStop = false;
            this.gbVoto.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_de_Votação.Properties.Resources.book_learning_notebook_reading_study_icon_127253;
            this.pictureBox3.Location = new System.Drawing.Point(433, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_Votação.Properties.Resources.child_reading_book_icon_icons_com_49293;
            this.pictureBox2.Location = new System.Drawing.Point(6, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Votação.Properties.Resources.child_reading_book_icon_icons_com_49293;
            this.pictureBox1.Location = new System.Drawing.Point(6, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sistema_de_Votação.Properties.Resources.lupa;
            this.pictureBox5.Location = new System.Drawing.Point(6, 276);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(118, 140);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sistema_de_Votação.Properties.Resources.Logout_37127;
            this.pictureBox4.Location = new System.Drawing.Point(433, 271);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 140);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(270, 49);
            this.bindingNavigatorAddNewItem.Text = "Iniciar Votação ";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.Habilitar);
            // 
            // urna666BindingNavigatorSaveItem
            // 
            this.urna666BindingNavigatorSaveItem.Enabled = false;
            this.urna666BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("urna666BindingNavigatorSaveItem.Image")));
            this.urna666BindingNavigatorSaveItem.Name = "urna666BindingNavigatorSaveItem";
            this.urna666BindingNavigatorSaveItem.Size = new System.Drawing.Size(302, 49);
            this.urna666BindingNavigatorSaveItem.Text = "Concluir Votação ";
            this.urna666BindingNavigatorSaveItem.Click += new System.EventHandler(this.urna666BindingNavigatorSaveItem_Click);
            // 
            // lblIniciarVotacao
            // 
            this.lblIniciarVotacao.AutoSize = true;
            this.lblIniciarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarVotacao.ForeColor = System.Drawing.Color.Red;
            this.lblIniciarVotacao.Location = new System.Drawing.Point(337, 130);
            this.lblIniciarVotacao.Name = "lblIniciarVotacao";
            this.lblIniciarVotacao.Size = new System.Drawing.Size(399, 37);
            this.lblIniciarVotacao.TabIndex = 12;
            this.lblIniciarVotacao.Text = "Clique em Inciar Votação";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.Color.Red;
            this.lblEscolha.Location = new System.Drawing.Point(97, 130);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(894, 37);
            this.lblEscolha.TabIndex = 13;
            this.lblEscolha.Text = "Escolha o Candidato Clicando no Círculo Correspondente";
            this.lblEscolha.Visible = false;
            // 
            // lblConcluir
            // 
            this.lblConcluir.AutoSize = true;
            this.lblConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcluir.ForeColor = System.Drawing.Color.Red;
            this.lblConcluir.Location = new System.Drawing.Point(180, 579);
            this.lblConcluir.Name = "lblConcluir";
            this.lblConcluir.Size = new System.Drawing.Size(671, 37);
            this.lblConcluir.TabIndex = 14;
            this.lblConcluir.Text = "Após Escolher Clique em Concluir Votação";
            this.lblConcluir.Visible = false;
            // 
            // frmVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 652);
            this.Controls.Add(this.lblConcluir);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.lblIniciarVotacao);
            this.Controls.Add(this.gbVoto);
            this.Controls.Add(this.urna666BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Votação ";
            this.Load += new System.EventHandler(this.frmVotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urna612DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urna666BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urna666BindingNavigator)).EndInit();
            this.urna666BindingNavigator.ResumeLayout(false);
            this.urna666BindingNavigator.PerformLayout();
            this.gbVoto.ResumeLayout(false);
            this.gbVoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Urna612DataSet urna612DataSet;
        private System.Windows.Forms.BindingSource urna666BindingSource;
        private Urna612DataSetTableAdapters.Urna666TableAdapter urna666TableAdapter;
        private Urna612DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator urna666BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton urna666BindingNavigatorSaveItem;
        private System.Windows.Forms.RadioButton pafuncioRadioButton;
        private System.Windows.Forms.RadioButton fudêncioRadioButton;
        private System.Windows.Forms.RadioButton nuloRadioButton;
        private System.Windows.Forms.RadioButton brancoRadioButton;
        private System.Windows.Forms.GroupBox gbVoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblIniciarVotacao;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblConcluir;
    }
}