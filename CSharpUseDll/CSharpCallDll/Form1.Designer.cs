namespace CSharpCallDll
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.normalVar = new System.Windows.Forms.Button();
            this.ptrVar = new System.Windows.Forms.Button();
            this.charX = new System.Windows.Forms.Button();
            this.callFunInCls = new System.Windows.Forms.Button();
            this.quote = new System.Windows.Forms.Button();
            this.array = new System.Windows.Forms.Button();
            this.outArr = new System.Windows.Forms.Button();
            this.outCharArr = new System.Windows.Forms.Button();
            this.structParam = new System.Windows.Forms.Button();
            this.structPtr = new System.Windows.Forms.Button();
            this.struct2 = new System.Windows.Forms.Button();
            this.GetPicWay1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GetPicWay2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // normalVar
            // 
            this.normalVar.Location = new System.Drawing.Point(12, 12);
            this.normalVar.Name = "normalVar";
            this.normalVar.Size = new System.Drawing.Size(115, 23);
            this.normalVar.TabIndex = 0;
            this.normalVar.Text = "普通变量";
            this.normalVar.UseVisualStyleBackColor = true;
            this.normalVar.Click += new System.EventHandler(this.normalVar_Click);
            // 
            // ptrVar
            // 
            this.ptrVar.Location = new System.Drawing.Point(12, 53);
            this.ptrVar.Name = "ptrVar";
            this.ptrVar.Size = new System.Drawing.Size(115, 23);
            this.ptrVar.TabIndex = 1;
            this.ptrVar.Text = "普通指针变量";
            this.ptrVar.UseVisualStyleBackColor = true;
            this.ptrVar.Click += new System.EventHandler(this.ptrVar_Click);
            // 
            // charX
            // 
            this.charX.Location = new System.Drawing.Point(12, 94);
            this.charX.Name = "charX";
            this.charX.Size = new System.Drawing.Size(115, 23);
            this.charX.TabIndex = 2;
            this.charX.Text = "char*";
            this.charX.UseVisualStyleBackColor = true;
            this.charX.Click += new System.EventHandler(this.charX_Click);
            // 
            // callFunInCls
            // 
            this.callFunInCls.Location = new System.Drawing.Point(13, 133);
            this.callFunInCls.Name = "callFunInCls";
            this.callFunInCls.Size = new System.Drawing.Size(114, 23);
            this.callFunInCls.TabIndex = 3;
            this.callFunInCls.Text = "调类方法";
            this.callFunInCls.UseVisualStyleBackColor = true;
            this.callFunInCls.Click += new System.EventHandler(this.callFunInCls_Click);
            // 
            // quote
            // 
            this.quote.Location = new System.Drawing.Point(13, 174);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(114, 23);
            this.quote.TabIndex = 4;
            this.quote.Text = "引用参数";
            this.quote.UseVisualStyleBackColor = true;
            this.quote.Click += new System.EventHandler(this.quote_Click);
            // 
            // array
            // 
            this.array.Location = new System.Drawing.Point(13, 218);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(114, 23);
            this.array.TabIndex = 5;
            this.array.Text = "数组参数";
            this.array.UseVisualStyleBackColor = true;
            this.array.Click += new System.EventHandler(this.array_Click);
            // 
            // outArr
            // 
            this.outArr.Location = new System.Drawing.Point(13, 257);
            this.outArr.Name = "outArr";
            this.outArr.Size = new System.Drawing.Size(114, 23);
            this.outArr.TabIndex = 6;
            this.outArr.Text = "传出数组";
            this.outArr.UseVisualStyleBackColor = true;
            this.outArr.Click += new System.EventHandler(this.outArr_Click);
            // 
            // outCharArr
            // 
            this.outCharArr.Location = new System.Drawing.Point(13, 296);
            this.outCharArr.Name = "outCharArr";
            this.outCharArr.Size = new System.Drawing.Size(114, 23);
            this.outCharArr.TabIndex = 7;
            this.outCharArr.Text = "char数组参数";
            this.outCharArr.UseVisualStyleBackColor = true;
            this.outCharArr.Click += new System.EventHandler(this.outCharArr_Click);
            // 
            // structParam
            // 
            this.structParam.Location = new System.Drawing.Point(13, 336);
            this.structParam.Name = "structParam";
            this.structParam.Size = new System.Drawing.Size(114, 23);
            this.structParam.TabIndex = 8;
            this.structParam.Text = "结构体参数";
            this.structParam.UseVisualStyleBackColor = true;
            this.structParam.Click += new System.EventHandler(this.structParam_Click);
            // 
            // structPtr
            // 
            this.structPtr.Location = new System.Drawing.Point(155, 11);
            this.structPtr.Name = "structPtr";
            this.structPtr.Size = new System.Drawing.Size(115, 23);
            this.structPtr.TabIndex = 9;
            this.structPtr.Text = "结构体指针参数";
            this.structPtr.UseVisualStyleBackColor = true;
            this.structPtr.Click += new System.EventHandler(this.structPtr_Click);
            // 
            // struct2
            // 
            this.struct2.Location = new System.Drawing.Point(155, 52);
            this.struct2.Name = "struct2";
            this.struct2.Size = new System.Drawing.Size(115, 23);
            this.struct2.TabIndex = 10;
            this.struct2.Text = "嵌套结构体参数";
            this.struct2.UseVisualStyleBackColor = true;
            this.struct2.Click += new System.EventHandler(this.struct2_Click);
            // 
            // GetPicWay1
            // 
            this.GetPicWay1.Location = new System.Drawing.Point(155, 94);
            this.GetPicWay1.Name = "GetPicWay1";
            this.GetPicWay1.Size = new System.Drawing.Size(115, 23);
            this.GetPicWay1.TabIndex = 11;
            this.GetPicWay1.Text = "传递图像1";
            this.GetPicWay1.UseVisualStyleBackColor = true;
            this.GetPicWay1.Click += new System.EventHandler(this.GetPicWay1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 229);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // GetPicWay2
            // 
            this.GetPicWay2.Location = new System.Drawing.Point(155, 133);
            this.GetPicWay2.Name = "GetPicWay2";
            this.GetPicWay2.Size = new System.Drawing.Size(115, 23);
            this.GetPicWay2.TabIndex = 13;
            this.GetPicWay2.Text = "传递图像2";
            this.GetPicWay2.UseVisualStyleBackColor = true;
            this.GetPicWay2.Click += new System.EventHandler(this.GetPicWay2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.GetPicWay2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GetPicWay1);
            this.Controls.Add(this.struct2);
            this.Controls.Add(this.structPtr);
            this.Controls.Add(this.structParam);
            this.Controls.Add(this.outCharArr);
            this.Controls.Add(this.outArr);
            this.Controls.Add(this.array);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.callFunInCls);
            this.Controls.Add(this.charX);
            this.Controls.Add(this.ptrVar);
            this.Controls.Add(this.normalVar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button normalVar;
        private System.Windows.Forms.Button ptrVar;
        private System.Windows.Forms.Button charX;
        private System.Windows.Forms.Button callFunInCls;
        private System.Windows.Forms.Button quote;
        private System.Windows.Forms.Button array;
        private System.Windows.Forms.Button outArr;
        private System.Windows.Forms.Button outCharArr;
        private System.Windows.Forms.Button structParam;
        private System.Windows.Forms.Button structPtr;
        private System.Windows.Forms.Button struct2;
        private System.Windows.Forms.Button GetPicWay1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GetPicWay2;
    }
}

