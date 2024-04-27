namespace PR_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationMultiply = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.Dictionary = new System.Windows.Forms.GroupBox();
            this.Cubing = new System.Windows.Forms.Button();
            this.Generation = new System.Windows.Forms.Button();
            this.textBoxNumbersKeys = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.GroupBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBoxNumbersValues = new System.Windows.Forms.TextBox();
            this.OutputToTheScreen = new System.Windows.Forms.GroupBox();
            this.textBoxNumbersExScreen = new System.Windows.Forms.TextBox();
            this.errorProviderSymbol = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberCharacters = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmptyLine = new System.Windows.Forms.ErrorProvider(this.components);
            this.ApplicationCubing = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureTask = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.Task.SuspendLayout();
            this.Dictionary.SuspendLayout();
            this.Value.SuspendLayout();
            this.OutputToTheScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(740, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeneration,
            this.ApplicationMultiply,
            this.ApplicationCubing});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(146, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeneration
            // 
            this.ApplicationGeneration.Name = "ApplicationGeneration";
            this.ApplicationGeneration.Size = new System.Drawing.Size(242, 22);
            this.ApplicationGeneration.Text = "Приложение \"Сгенерировать\"";
            this.ApplicationGeneration.Click += new System.EventHandler(this.ApplicationGeneration_Click);
            // 
            // ApplicationMultiply
            // 
            this.ApplicationMultiply.Name = "ApplicationMultiply";
            this.ApplicationMultiply.Size = new System.Drawing.Size(242, 22);
            this.ApplicationMultiply.Text = "Приложение \"Перемножить\"";
            this.ApplicationMultiply.Click += new System.EventHandler(this.ApplicationMultiply_Click);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(146, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            this.Reference.Click += new System.EventHandler(this.Reference_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(180, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Task.Controls.Add(this.pictureTask);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(681, 92);
            this.Task.TabIndex = 2;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dictionary.Controls.Add(this.Generation);
            this.Dictionary.Controls.Add(this.textBoxNumbersKeys);
            this.Dictionary.Location = new System.Drawing.Point(12, 125);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(237, 92);
            this.Dictionary.TabIndex = 3;
            this.Dictionary.TabStop = false;
            this.Dictionary.Text = "Словарь генераций:";
            this.Dictionary.Enter += new System.EventHandler(this.Dictionary_Enter);
            // 
            // Cubing
            // 
            this.Cubing.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cubing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cubing.Location = new System.Drawing.Point(373, 245);
            this.Cubing.Name = "Cubing";
            this.Cubing.Size = new System.Drawing.Size(125, 10);
            this.Cubing.TabIndex = 8;
            this.Cubing.Text = "Возвести в куб";
            this.Cubing.UseVisualStyleBackColor = false;
            this.Cubing.Click += new System.EventHandler(this.Cubing_Click);
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Generation.Location = new System.Drawing.Point(6, 48);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(192, 35);
            this.Generation.TabIndex = 7;
            this.Generation.Text = "Сгенерировать ключи (x5)";
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // textBoxNumbersKeys
            // 
            this.textBoxNumbersKeys.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersKeys.Name = "textBoxNumbersKeys";
            this.textBoxNumbersKeys.Size = new System.Drawing.Size(204, 20);
            this.textBoxNumbersKeys.TabIndex = 6;
            this.textBoxNumbersKeys.TextChanged += new System.EventHandler(this.textBoxNumbersKeys_TextChanged);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(504, 195);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 60);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(616, 200);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Value.Controls.Add(this.Multiply);
            this.Value.Controls.Add(this.textBoxNumbersValues);
            this.Value.Location = new System.Drawing.Point(255, 125);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(209, 92);
            this.Value.TabIndex = 8;
            this.Value.TabStop = false;
            this.Value.Text = "Значения (^3):";
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Multiply.Location = new System.Drawing.Point(6, 48);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(118, 35);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "Перемножить";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // textBoxNumbersValues
            // 
            this.textBoxNumbersValues.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersValues.Name = "textBoxNumbersValues";
            this.textBoxNumbersValues.ReadOnly = true;
            this.textBoxNumbersValues.Size = new System.Drawing.Size(197, 20);
            this.textBoxNumbersValues.TabIndex = 6;
            this.textBoxNumbersValues.TextChanged += new System.EventHandler(this.textBoxNumbersValues_TextChanged);
            // 
            // OutputToTheScreen
            // 
            this.OutputToTheScreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputToTheScreen.Controls.Add(this.textBoxNumbersExScreen);
            this.OutputToTheScreen.Location = new System.Drawing.Point(470, 125);
            this.OutputToTheScreen.Name = "OutputToTheScreen";
            this.OutputToTheScreen.Size = new System.Drawing.Size(261, 64);
            this.OutputToTheScreen.TabIndex = 9;
            this.OutputToTheScreen.TabStop = false;
            this.OutputToTheScreen.Text = "Вывод на экран:";
            // 
            // textBoxNumbersExScreen
            // 
            this.textBoxNumbersExScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxNumbersExScreen.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersExScreen.Name = "textBoxNumbersExScreen";
            this.textBoxNumbersExScreen.ReadOnly = true;
            this.textBoxNumbersExScreen.Size = new System.Drawing.Size(246, 30);
            this.textBoxNumbersExScreen.TabIndex = 6;
            this.textBoxNumbersExScreen.TextChanged += new System.EventHandler(this.textBoxNumbersExScreen_TextChanged);
            // 
            // errorProviderSymbol
            // 
            this.errorProviderSymbol.BlinkRate = 300;
            this.errorProviderSymbol.ContainerControl = this;
            // 
            // errorProviderNull
            // 
            this.errorProviderNull.ContainerControl = this;
            // 
            // errorProviderNumberCharacters
            // 
            this.errorProviderNumberCharacters.ContainerControl = this;
            // 
            // errorProviderEmptyLine
            // 
            this.errorProviderEmptyLine.ContainerControl = this;
            // 
            // ApplicationCubing
            // 
            this.ApplicationCubing.Name = "ApplicationCubing";
            this.ApplicationCubing.Size = new System.Drawing.Size(242, 22);
            this.ApplicationCubing.Text = "Приложение \"Возвести в куб\"";
            this.ApplicationCubing.Click += new System.EventHandler(this.ApplicationCubing_Click);
            // 
            // pictureTask
            // 
            this.pictureTask.Image = global::PR_3.Properties.Resources._2;
            this.pictureTask.Location = new System.Drawing.Point(19, 19);
            this.pictureTask.Name = "pictureTask";
            this.pictureTask.Size = new System.Drawing.Size(645, 63);
            this.pictureTask.TabIndex = 0;
            this.pictureTask.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 266);
            this.Controls.Add(this.Cubing);
            this.Controls.Add(this.OutputToTheScreen);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Task.ResumeLayout(false);
            this.Dictionary.ResumeLayout(false);
            this.Dictionary.PerformLayout();
            this.Value.ResumeLayout(false);
            this.Value.PerformLayout();
            this.OutputToTheScreen.ResumeLayout(false);
            this.OutputToTheScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmptyLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureTask;
        private System.Windows.Forms.GroupBox Dictionary;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.TextBox textBoxNumbersKeys;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox Value;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBoxNumbersValues;
        private System.Windows.Forms.GroupBox OutputToTheScreen;
        private System.Windows.Forms.TextBox textBoxNumbersExScreen;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeneration;
        private System.Windows.Forms.ToolStripMenuItem ApplicationMultiply;
        private System.Windows.Forms.ErrorProvider errorProviderSymbol;
        private System.Windows.Forms.ErrorProvider errorProviderNull;
        private System.Windows.Forms.ErrorProvider errorProviderNumberCharacters;
        private System.Windows.Forms.ErrorProvider errorProviderEmptyLine;
        private System.Windows.Forms.Button Cubing;
        private System.Windows.Forms.ToolStripMenuItem ApplicationCubing;
    }
}

