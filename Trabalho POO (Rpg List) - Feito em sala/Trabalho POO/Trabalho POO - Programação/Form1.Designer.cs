namespace Trabalho_POO___Programação
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.UsarItem = new System.Windows.Forms.Button();
            this.DescriBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // InfoBox
            // 
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoBox.Location = new System.Drawing.Point(472, 93);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(137, 20);
            this.InfoBox.TabIndex = 1;
            this.InfoBox.TextChanged += new System.EventHandler(this.InfoBox_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(516, 202);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(93, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Adicionar item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(642, 202);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remover Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // UsarItem
            // 
            this.UsarItem.Location = new System.Drawing.Point(580, 299);
            this.UsarItem.Name = "UsarItem";
            this.UsarItem.Size = new System.Drawing.Size(86, 23);
            this.UsarItem.TabIndex = 4;
            this.UsarItem.Text = "Usar Item";
            this.UsarItem.UseVisualStyleBackColor = true;
            this.UsarItem.Click += new System.EventHandler(this.UsarItem_Click);
            // 
            // DescriBox
            // 
            this.DescriBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriBox.Location = new System.Drawing.Point(666, 93);
            this.DescriBox.Name = "DescriBox";
            this.DescriBox.Size = new System.Drawing.Size(137, 20);
            this.DescriBox.TabIndex = 5;
            this.DescriBox.TextChanged += new System.EventHandler(this.DescriBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(487, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = " Ação";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(682, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Descrição";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 535);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DescriBox);
            this.Controls.Add(this.UsarItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button UsarItem;
        private System.Windows.Forms.TextBox DescriBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

