namespace LW6_IP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RLEButton = new System.Windows.Forms.Button();
            this.HaffmanButton = new System.Windows.Forms.Button();
            this.Decode_Huffman = new System.Windows.Forms.Button();
            this.Decode_RLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(176, 90);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(256, 23);
            this.input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RLEButton
            // 
            this.RLEButton.Location = new System.Drawing.Point(178, 131);
            this.RLEButton.Name = "RLEButton";
            this.RLEButton.Size = new System.Drawing.Size(168, 38);
            this.RLEButton.TabIndex = 2;
            this.RLEButton.Text = "Сжать файл (способ RLE)";
            this.RLEButton.UseVisualStyleBackColor = true;
            this.RLEButton.Click += new System.EventHandler(this.RLEButton_Click);
            // 
            // HaffmanButton
            // 
            this.HaffmanButton.Location = new System.Drawing.Point(372, 131);
            this.HaffmanButton.Name = "HaffmanButton";
            this.HaffmanButton.Size = new System.Drawing.Size(176, 38);
            this.HaffmanButton.TabIndex = 3;
            this.HaffmanButton.Text = "Сжать файл (алгоритм Хаффмана)";
            this.HaffmanButton.UseVisualStyleBackColor = true;
            this.HaffmanButton.Click += new System.EventHandler(this.HaffmanButton_Click);
            // 
            // Decode_Huffman
            // 
            this.Decode_Huffman.Location = new System.Drawing.Point(372, 188);
            this.Decode_Huffman.Name = "Decode_Huffman";
            this.Decode_Huffman.Size = new System.Drawing.Size(176, 38);
            this.Decode_Huffman.TabIndex = 4;
            this.Decode_Huffman.Text = "Раскодировать файл Хаффмана";
            this.Decode_Huffman.UseVisualStyleBackColor = true;
            this.Decode_Huffman.Click += new System.EventHandler(this.Decode_Huffman_Click);
            // 
            // Decode_RLE
            // 
            this.Decode_RLE.Location = new System.Drawing.Point(178, 188);
            this.Decode_RLE.Name = "Decode_RLE";
            this.Decode_RLE.Size = new System.Drawing.Size(176, 38);
            this.Decode_RLE.TabIndex = 5;
            this.Decode_RLE.Text = "Раскодировать файл RLE";
            this.Decode_RLE.UseVisualStyleBackColor = true;
            this.Decode_RLE.Click += new System.EventHandler(this.Decode_RLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decode_RLE);
            this.Controls.Add(this.Decode_Huffman);
            this.Controls.Add(this.HaffmanButton);
            this.Controls.Add(this.RLEButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "LW6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input;
        private Button button1;
        private Button RLEButton;
        private Button HaffmanButton;
        private Button Decode_Huffman;
        private Button Decode_RLE;
    }
}