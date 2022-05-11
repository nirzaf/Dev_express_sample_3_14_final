using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sample_3_14 {
  public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
    public Form1() {
      InitializeComponent();


    }

    private void workspaceManager1_WorkspaceCollectionChanged(object sender, DevExpress.Utils.WorkspaceCollectionChangedEventArgs ea) {
      workspaceManager1.SaveWorkspaces("workspaces.xml");
    }

    private void Form1_Load(object sender, EventArgs e) {
      workspaceManager1.LoadWorkspaces("workspaces.xml");
    }
  }
}
