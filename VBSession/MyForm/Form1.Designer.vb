<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sbmtBtn = New System.Windows.Forms.Button()
        Me.txtbx = New System.Windows.Forms.TextBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'sbmtBtn
        '
        Me.sbmtBtn.Location = New System.Drawing.Point(76, 245)
        Me.sbmtBtn.Name = "sbmtBtn"
        Me.sbmtBtn.Size = New System.Drawing.Size(75, 23)
        Me.sbmtBtn.TabIndex = 0
        Me.sbmtBtn.Text = "Submit"
        Me.sbmtBtn.UseVisualStyleBackColor = True
        '
        'txtbx
        '
        Me.txtbx.Location = New System.Drawing.Point(59, 78)
        Me.txtbx.Name = "txtbx"
        Me.txtbx.Size = New System.Drawing.Size(121, 20)
        Me.txtbx.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(59, 117)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(121, 97)
        Me.TreeView1.TabIndex = 3
        '
        'myFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(253, 318)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.txtbx)
        Me.Controls.Add(Me.sbmtBtn)
        Me.Name = "myFrm"
        Me.Text = "My Cool Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sbmtBtn As Button
    Friend WithEvents txtbx As TextBox
    Friend WithEvents TreeView1 As TreeView
End Class
