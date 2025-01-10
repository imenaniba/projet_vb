<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formgestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl_usr = New Label()
        lbl_psd = New Label()
        lbl_role = New Label()
        txt_usr = New TextBox()
        txt_psd = New TextBox()
        cmb_role = New ComboBox()
        btn_connexion = New Button()
        SuspendLayout()
        ' 
        ' lbl_usr
        ' 
        lbl_usr.AutoSize = True
        lbl_usr.Font = New Font("Sitka Text", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_usr.ForeColor = SystemColors.ControlDarkDark
        lbl_usr.Location = New Point(34, 49)
        lbl_usr.Name = "lbl_usr"
        lbl_usr.Size = New Size(203, 53)
        lbl_usr.TabIndex = 0
        lbl_usr.Text = "Username"
        ' 
        ' lbl_psd
        ' 
        lbl_psd.AutoSize = True
        lbl_psd.Font = New Font("Sitka Text", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_psd.ForeColor = SystemColors.ControlDarkDark
        lbl_psd.Location = New Point(34, 160)
        lbl_psd.Name = "lbl_psd"
        lbl_psd.Size = New Size(195, 53)
        lbl_psd.TabIndex = 1
        lbl_psd.Text = "Password"
        ' 
        ' lbl_role
        ' 
        lbl_role.AutoSize = True
        lbl_role.Font = New Font("Sitka Text", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_role.ForeColor = SystemColors.ControlDarkDark
        lbl_role.Location = New Point(34, 274)
        lbl_role.Name = "lbl_role"
        lbl_role.Size = New Size(102, 53)
        lbl_role.TabIndex = 2
        lbl_role.Text = "Role"
        ' 
        ' txt_usr
        ' 
        txt_usr.Location = New Point(260, 62)
        txt_usr.Name = "txt_usr"
        txt_usr.Size = New Size(213, 27)
        txt_usr.TabIndex = 3
        ' 
        ' txt_psd
        ' 
        txt_psd.Location = New Point(260, 186)
        txt_psd.Name = "txt_psd"
        txt_psd.Size = New Size(213, 27)
        txt_psd.TabIndex = 4
        txt_psd.UseSystemPasswordChar = True
        ' 
        ' cmb_role
        ' 
        cmb_role.FormattingEnabled = True
        cmb_role.Location = New Point(260, 299)
        cmb_role.Name = "cmb_role"
        cmb_role.Size = New Size(213, 28)
        cmb_role.TabIndex = 6
        ' 
        ' btn_connexion
        ' 
        btn_connexion.Font = New Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn_connexion.ForeColor = SystemColors.HotTrack
        btn_connexion.Location = New Point(170, 375)
        btn_connexion.Name = "btn_connexion"
        btn_connexion.Size = New Size(233, 48)
        btn_connexion.TabIndex = 7
        btn_connexion.Text = "Connexion"
        btn_connexion.UseVisualStyleBackColor = True
        ' 
        ' formgestion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(800, 450)
        Controls.Add(btn_connexion)
        Controls.Add(cmb_role)
        Controls.Add(txt_psd)
        Controls.Add(txt_usr)
        Controls.Add(lbl_role)
        Controls.Add(lbl_psd)
        Controls.Add(lbl_usr)
        Name = "formgestion"
        Text = "formgestion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_usr As Label
    Friend WithEvents lbl_psd As Label
    Friend WithEvents lbl_role As Label
    Friend WithEvents txt_usr As TextBox
    Friend WithEvents txt_psd As TextBox
    Friend WithEvents cmb_role As ComboBox
    Friend WithEvents btn_connexion As Button

End Class
