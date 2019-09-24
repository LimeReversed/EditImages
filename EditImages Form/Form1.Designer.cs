namespace EditImages_Form
{
    partial class ImageEditForm
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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbManipulated = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnBlurred = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialogue = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExtraBlurry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManipulated)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginal.Location = new System.Drawing.Point(3, 23);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(323, 214);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // pbManipulated
            // 
            this.pbManipulated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbManipulated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbManipulated.Location = new System.Drawing.Point(345, 23);
            this.pbManipulated.Name = "pbManipulated";
            this.pbManipulated.Size = new System.Drawing.Size(325, 214);
            this.pbManipulated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManipulated.TabIndex = 1;
            this.pbManipulated.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manipulated";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(148, 262);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 34);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnGray
            // 
            this.btnGray.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGray.Enabled = false;
            this.btnGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGray.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.ForeColor = System.Drawing.Color.White;
            this.btnGray.Location = new System.Drawing.Point(293, 262);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(125, 34);
            this.btnGray.TabIndex = 5;
            this.btnGray.Text = "Make gray";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.BtnGray_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNegative.Enabled = false;
            this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegative.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.ForeColor = System.Drawing.Color.White;
            this.btnNegative.Location = new System.Drawing.Point(438, 262);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(125, 34);
            this.btnNegative.TabIndex = 6;
            this.btnNegative.Text = "Make negative";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            // 
            // btnBlurred
            // 
            this.btnBlurred.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBlurred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBlurred.Enabled = false;
            this.btnBlurred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlurred.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlurred.ForeColor = System.Drawing.Color.White;
            this.btnBlurred.Location = new System.Drawing.Point(148, 302);
            this.btnBlurred.Name = "btnBlurred";
            this.btnBlurred.Size = new System.Drawing.Size(125, 34);
            this.btnBlurred.TabIndex = 7;
            this.btnBlurred.Text = "Make blurry";
            this.btnBlurred.UseVisualStyleBackColor = false;
            this.btnBlurred.Click += new System.EventHandler(this.BtnBlurred_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(438, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialogue
            // 
            this.openFileDialogue.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.Controls.Add(this.pbOriginal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbManipulated, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 240);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // btnExtraBlurry
            // 
            this.btnExtraBlurry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExtraBlurry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtraBlurry.Enabled = false;
            this.btnExtraBlurry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraBlurry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraBlurry.ForeColor = System.Drawing.Color.White;
            this.btnExtraBlurry.Location = new System.Drawing.Point(293, 302);
            this.btnExtraBlurry.Name = "btnExtraBlurry";
            this.btnExtraBlurry.Size = new System.Drawing.Size(125, 34);
            this.btnExtraBlurry.TabIndex = 8;
            this.btnExtraBlurry.Text = "Make Xtra blurry";
            this.btnExtraBlurry.UseVisualStyleBackColor = false;
            this.btnExtraBlurry.Click += new System.EventHandler(this.BtnExtraBlurry_Click);
            // 
            // ImageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::EditImages_Form.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 353);
            this.Controls.Add(this.btnExtraBlurry);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBlurred);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnBrowse);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(720, 338);
            this.Name = "ImageEditForm";
            this.Text = "ImageEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManipulated)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbManipulated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnBlurred;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogue;
        private System.Windows.Forms.OpenFileDialog openFileDialogue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExtraBlurry;
    }
}

