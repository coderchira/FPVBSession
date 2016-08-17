Public Class myFrm
    Private Sub myFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Form loaded!")
        sbmtBtn.Enabled = False
    End Sub

    Private Sub sbmtBtn_Click(sender As Object, e As EventArgs) Handles sbmtBtn.Click
        MessageBox.Show("The button is clicked!")
        TreeView1.Nodes.Add(1)
    End Sub

    Private Sub txtbx_Click(sender As Object, e As EventArgs) Handles txtbx.Click

    End Sub

    Private Sub txtbx_TextChanged(sender As Object, e As EventArgs) Handles txtbx.TextChanged
        txtbx.BackColor = Color.Red
        txtbx.ForeColor = Color.Yellow
        sbmtBtn.Enabled = True
    End Sub



    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        e.Node.Text = "Clicked!"
    End Sub
End Class
