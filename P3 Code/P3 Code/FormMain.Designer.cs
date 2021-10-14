
using System;

namespace P3_Code
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.issuesToolStripMenuItem,
            this.requirementsToolStripMenuItem,
            this.designsToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            this.selectProjectToolStripMenuItem.Click += new System.EventHandler(this.selectProjectToolStripMenuItem_Click);
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.issuesToolStripMenuItem.Text = "Issues";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.removeToolStripMenuItem.Text = "Modify";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modifyToolStripMenuItem.Text = "Remove";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countByAssigneeToolStripMenuItem,
            this.listByAssigneeToolStripMenuItem,
            this.countByArtifactToolStripMenuItem,
            this.listByArtifactToolStripMenuItem,
            this.countByDateRangeToolStripMenuItem,
            this.listByDateRangeToolStripMenuItem,
            this.trendByDateRangeToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // countByAssigneeToolStripMenuItem
            // 
            this.countByAssigneeToolStripMenuItem.Name = "countByAssigneeToolStripMenuItem";
            this.countByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            // 
            // listByAssigneeToolStripMenuItem
            // 
            this.listByAssigneeToolStripMenuItem.Name = "listByAssigneeToolStripMenuItem";
            this.listByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByAssigneeToolStripMenuItem.Text = "List by Assignee";
            // 
            // countByArtifactToolStripMenuItem
            // 
            this.countByArtifactToolStripMenuItem.Name = "countByArtifactToolStripMenuItem";
            this.countByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByArtifactToolStripMenuItem.Text = "Count by Artifact";
            // 
            // listByArtifactToolStripMenuItem
            // 
            this.listByArtifactToolStripMenuItem.Name = "listByArtifactToolStripMenuItem";
            this.listByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByArtifactToolStripMenuItem.Text = "List by Artifact";
            // 
            // countByDateRangeToolStripMenuItem
            // 
            this.countByDateRangeToolStripMenuItem.Name = "countByDateRangeToolStripMenuItem";
            this.countByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            // 
            // listByDateRangeToolStripMenuItem
            // 
            this.listByDateRangeToolStripMenuItem.Name = "listByDateRangeToolStripMenuItem";
            this.listByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByDateRangeToolStripMenuItem.Text = "List by Date Range";
            // 
            // trendByDateRangeToolStripMenuItem
            // 
            this.trendByDateRangeToolStripMenuItem.Name = "trendByDateRangeToolStripMenuItem";
            this.trendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.trendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            // 
            // requirementsToolStripMenuItem
            // 
            this.requirementsToolStripMenuItem.Name = "requirementsToolStripMenuItem";
            this.requirementsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.requirementsToolStripMenuItem.Text = "Requirements";
            // 
            // designsToolStripMenuItem
            // 
            this.designsToolStripMenuItem.Name = "designsToolStripMenuItem";
            this.designsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.designsToolStripMenuItem.Text = "Designs";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendByDateRangeToolStripMenuItem;
    }
}