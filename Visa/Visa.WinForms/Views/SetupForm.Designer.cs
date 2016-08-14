﻿namespace Visa.WinForms.Views
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOk = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditNationality = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.toggleSwitchCloseBrowser = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitchRepeatIfCrash = new DevExpress.XtraEditors.ToggleSwitch();
            this.spinEditPeopleCount = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditChildCount = new DevExpress.XtraEditors.SpinEdit();
            this.textEditUrl = new DevExpress.XtraEditors.HyperLinkEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNationality = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCloseBrower = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRepeatIfCrash = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemChildCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPeopleCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNationality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchCloseBrowser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchRepeatIfCrash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPeopleCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditChildCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCloseBrower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRepeatIfCrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChildCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPeopleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditEmail);
            this.layoutControl1.Controls.Add(this.simpleButtonCancel);
            this.layoutControl1.Controls.Add(this.simpleButtonOk);
            this.layoutControl1.Controls.Add(this.lookUpEditNationality);
            this.layoutControl1.Controls.Add(this.textEditPassword);
            this.layoutControl1.Controls.Add(this.toggleSwitchCloseBrowser);
            this.layoutControl1.Controls.Add(this.toggleSwitchRepeatIfCrash);
            this.layoutControl1.Controls.Add(this.spinEditPeopleCount);
            this.layoutControl1.Controls.Add(this.spinEditChildCount);
            this.layoutControl1.Controls.Add(this.textEditUrl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(429, 247);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(173, 188);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.Mask.BeepOnError = true;
            this.textEditEmail.Properties.Mask.EditMask = "[a-zA-z0-9.]+@[a-zA-z0-9]+.[a-zA-z0-9]{2,3}";
            this.textEditEmail.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditEmail.Properties.Mask.PlaceHolder = '*';
            this.textEditEmail.Size = new System.Drawing.Size(244, 20);
            this.textEditEmail.StyleController = this.layoutControl1;
            this.textEditEmail.TabIndex = 13;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(216, 212);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(201, 22);
            this.simpleButtonCancel.StyleController = this.layoutControl1;
            this.simpleButtonCancel.TabIndex = 9;
            this.simpleButtonCancel.Text = "simpleButtonCancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonOk
            // 
            this.simpleButtonOk.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonOk.Image")));
            this.simpleButtonOk.Location = new System.Drawing.Point(12, 212);
            this.simpleButtonOk.Name = "simpleButtonOk";
            this.simpleButtonOk.Size = new System.Drawing.Size(200, 22);
            this.simpleButtonOk.StyleController = this.layoutControl1;
            this.simpleButtonOk.TabIndex = 8;
            this.simpleButtonOk.Text = "simpleButtonOk";
            this.simpleButtonOk.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEditNationality
            // 
            this.lookUpEditNationality.Location = new System.Drawing.Point(173, 84);
            this.lookUpEditNationality.Name = "lookUpEditNationality";
            this.lookUpEditNationality.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNationality.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Національність")});
            this.lookUpEditNationality.Properties.DisplayMember = "Name";
            this.lookUpEditNationality.Properties.ValueMember = "Value";
            this.lookUpEditNationality.Size = new System.Drawing.Size(244, 20);
            this.lookUpEditNationality.StyleController = this.layoutControl1;
            this.lookUpEditNationality.TabIndex = 7;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(173, 60);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(244, 20);
            this.textEditPassword.StyleController = this.layoutControl1;
            this.textEditPassword.TabIndex = 6;
            // 
            // toggleSwitchCloseBrowser
            // 
            this.toggleSwitchCloseBrowser.Location = new System.Drawing.Point(173, 108);
            this.toggleSwitchCloseBrowser.Name = "toggleSwitchCloseBrowser";
            this.toggleSwitchCloseBrowser.Properties.OffText = "Off";
            this.toggleSwitchCloseBrowser.Properties.OnText = "On";
            this.toggleSwitchCloseBrowser.Size = new System.Drawing.Size(244, 24);
            this.toggleSwitchCloseBrowser.StyleController = this.layoutControl1;
            this.toggleSwitchCloseBrowser.TabIndex = 4;
            // 
            // toggleSwitchRepeatIfCrash
            // 
            this.toggleSwitchRepeatIfCrash.Location = new System.Drawing.Point(173, 136);
            this.toggleSwitchRepeatIfCrash.Name = "toggleSwitchRepeatIfCrash";
            this.toggleSwitchRepeatIfCrash.Properties.OffText = "Off";
            this.toggleSwitchRepeatIfCrash.Properties.OnText = "On";
            this.toggleSwitchRepeatIfCrash.Size = new System.Drawing.Size(244, 24);
            this.toggleSwitchRepeatIfCrash.StyleController = this.layoutControl1;
            this.toggleSwitchRepeatIfCrash.TabIndex = 4;
            // 
            // spinEditPeopleCount
            // 
            this.spinEditPeopleCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPeopleCount.Location = new System.Drawing.Point(173, 12);
            this.spinEditPeopleCount.Name = "spinEditPeopleCount";
            this.spinEditPeopleCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPeopleCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEditPeopleCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditPeopleCount.Size = new System.Drawing.Size(244, 20);
            this.spinEditPeopleCount.StyleController = this.layoutControl1;
            this.spinEditPeopleCount.TabIndex = 11;
            // 
            // spinEditChildCount
            // 
            this.spinEditChildCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditChildCount.Location = new System.Drawing.Point(173, 36);
            this.spinEditChildCount.Name = "spinEditChildCount";
            this.spinEditChildCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditChildCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEditChildCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditChildCount.Size = new System.Drawing.Size(244, 20);
            this.spinEditChildCount.StyleController = this.layoutControl1;
            this.spinEditChildCount.TabIndex = 10;
            // 
            // textEditUrl
            // 
            this.textEditUrl.EditValue = "";
            this.textEditUrl.Location = new System.Drawing.Point(173, 164);
            this.textEditUrl.Name = "textEditUrl";
            this.textEditUrl.Properties.Mask.EditMask = "http.+";
            this.textEditUrl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditUrl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.textEditUrl.Size = new System.Drawing.Size(244, 20);
            this.textEditUrl.StyleController = this.layoutControl1;
            this.textEditUrl.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemPassword,
            this.layoutControlItemNationality,
            this.layoutControlItemCloseBrower,
            this.layoutControlItemRepeatIfCrash,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItemChildCount,
            this.layoutControlItemPeopleCount,
            this.layoutControlItemUrl,
            this.layoutControlItemEmail});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(429, 247);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemPassword
            // 
            this.layoutControlItemPassword.Control = this.textEditPassword;
            this.layoutControlItemPassword.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemPassword.Name = "layoutControlItemPassword";
            this.layoutControlItemPassword.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemPassword.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemNationality
            // 
            this.layoutControlItemNationality.Control = this.lookUpEditNationality;
            this.layoutControlItemNationality.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemNationality.Name = "layoutControlItemNationality";
            this.layoutControlItemNationality.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemNationality.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemCloseBrower
            // 
            this.layoutControlItemCloseBrower.Control = this.toggleSwitchCloseBrowser;
            this.layoutControlItemCloseBrower.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItemCloseBrower.Name = "layoutControlItemCloseBrower";
            this.layoutControlItemCloseBrower.Size = new System.Drawing.Size(409, 28);
            this.layoutControlItemCloseBrower.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemRepeatIfCrash
            // 
            this.layoutControlItemRepeatIfCrash.Control = this.toggleSwitchRepeatIfCrash;
            this.layoutControlItemRepeatIfCrash.CustomizationFormText = "layoutControlItemRepeatIfCrash";
            this.layoutControlItemRepeatIfCrash.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItemRepeatIfCrash.Name = "layoutControlItemRepeatIfCrash";
            this.layoutControlItemRepeatIfCrash.Size = new System.Drawing.Size(409, 28);
            this.layoutControlItemRepeatIfCrash.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonOk;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(204, 27);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(204, 200);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItemChildCount
            // 
            this.layoutControlItemChildCount.Control = this.spinEditChildCount;
            this.layoutControlItemChildCount.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemChildCount.Name = "layoutControlItemChildCount";
            this.layoutControlItemChildCount.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemChildCount.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemPeopleCount
            // 
            this.layoutControlItemPeopleCount.Control = this.spinEditPeopleCount;
            this.layoutControlItemPeopleCount.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemPeopleCount.Name = "layoutControlItemPeopleCount";
            this.layoutControlItemPeopleCount.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemPeopleCount.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemUrl
            // 
            this.layoutControlItemUrl.Control = this.textEditUrl;
            this.layoutControlItemUrl.CustomizationFormText = "layoutControlItemUrl";
            this.layoutControlItemUrl.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItemUrl.Name = "layoutControlItemUrl";
            this.layoutControlItemUrl.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemUrl.TextSize = new System.Drawing.Size(158, 13);
            // 
            // layoutControlItemEmail
            // 
            this.layoutControlItemEmail.Control = this.textEditEmail;
            this.layoutControlItemEmail.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItemEmail.Name = "layoutControlItemEmail";
            this.layoutControlItemEmail.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItemEmail.TextSize = new System.Drawing.Size(158, 13);
            // 
            // SetupForm
            // 
            this.AcceptButton = this.simpleButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(429, 247);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNationality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchCloseBrowser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchRepeatIfCrash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPeopleCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditChildCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCloseBrower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRepeatIfCrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChildCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPeopleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNationality;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchCloseBrowser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCloseBrower;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNationality;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchRepeatIfCrash;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRepeatIfCrash;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOk;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemChildCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPeopleCount;
        private DevExpress.XtraEditors.SpinEdit spinEditPeopleCount;
        private DevExpress.XtraEditors.SpinEdit spinEditChildCount;
        private DevExpress.XtraEditors.HyperLinkEdit textEditUrl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemUrl;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemEmail;
    }
}