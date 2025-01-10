<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formadmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_ajout = New Button()
        btn_modif = New Button()
        btn_supp = New Button()
        lbl_num = New Label()
        Label1 = New Label()
        lbl_time = New Label()
        lbl_des = New Label()
        lbl_nbp = New Label()
        lbl_prix = New Label()
        txt_num = New TextBox()
        txt_des = New TextBox()
        txt_prix = New TextBox()
        txt_nbp = New TextBox()
        pick_dt = New DateTimePicker()
        dgv_vols = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        Date_heure = New DataGridViewTextBoxColumn()
        nbplace = New DataGridViewTextBoxColumn()
        prix = New DataGridViewTextBoxColumn()
        btn_deconnexion = New Button()
        CType(dgv_vols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_ajout
        ' 
        btn_ajout.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        btn_ajout.ForeColor = SystemColors.ActiveCaption
        btn_ajout.Location = New Point(39, 334)
        btn_ajout.Name = "btn_ajout"
        btn_ajout.Size = New Size(173, 46)
        btn_ajout.TabIndex = 0
        btn_ajout.Text = "Ajouter"
        btn_ajout.UseVisualStyleBackColor = True
        ' 
        ' btn_modif
        ' 
        btn_modif.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        btn_modif.ForeColor = SystemColors.ActiveCaption
        btn_modif.Location = New Point(290, 334)
        btn_modif.Name = "btn_modif"
        btn_modif.Size = New Size(173, 46)
        btn_modif.TabIndex = 1
        btn_modif.Text = "Modifier"
        btn_modif.UseVisualStyleBackColor = True
        ' 
        ' btn_supp
        ' 
        btn_supp.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        btn_supp.ForeColor = SystemColors.ActiveCaption
        btn_supp.Location = New Point(545, 334)
        btn_supp.Name = "btn_supp"
        btn_supp.Size = New Size(173, 46)
        btn_supp.TabIndex = 2
        btn_supp.Text = "supprimer"
        btn_supp.UseVisualStyleBackColor = True
        ' 
        ' lbl_num
        ' 
        lbl_num.AutoSize = True
        lbl_num.Font = New Font("Source Sans Pro", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_num.ForeColor = Color.Fuchsia
        lbl_num.Location = New Point(84, 19)
        lbl_num.Name = "lbl_num"
        lbl_num.Size = New Size(168, 35)
        lbl_num.TabIndex = 3
        lbl_num.Text = "Numéro vole"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(374, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 4
        ' 
        ' lbl_time
        ' 
        lbl_time.AutoSize = True
        lbl_time.Font = New Font("Source Sans Pro", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_time.ForeColor = Color.Fuchsia
        lbl_time.Location = New Point(84, 129)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(202, 35)
        lbl_time.TabIndex = 5
        lbl_time.Text = "la date et heure"
        ' 
        ' lbl_des
        ' 
        lbl_des.AutoSize = True
        lbl_des.Font = New Font("Source Sans Pro", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_des.ForeColor = Color.Fuchsia
        lbl_des.Location = New Point(474, 19)
        lbl_des.Name = "lbl_des"
        lbl_des.Size = New Size(152, 35)
        lbl_des.TabIndex = 6
        lbl_des.Text = "Destination"
        ' 
        ' lbl_nbp
        ' 
        lbl_nbp.Font = New Font("Source Sans Pro", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_nbp.ForeColor = Color.Fuchsia
        lbl_nbp.Location = New Point(490, 129)
        lbl_nbp.Name = "lbl_nbp"
        lbl_nbp.Size = New Size(215, 35)
        lbl_nbp.TabIndex = 7
        lbl_nbp.Text = "nombres places"
        ' 
        ' lbl_prix
        ' 
        lbl_prix.AutoSize = True
        lbl_prix.Font = New Font("Source Sans Pro", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_prix.ForeColor = Color.Fuchsia
        lbl_prix.Location = New Point(329, 215)
        lbl_prix.Name = "lbl_prix"
        lbl_prix.Size = New Size(63, 35)
        lbl_prix.TabIndex = 8
        lbl_prix.Text = "Prix"
        ' 
        ' txt_num
        ' 
        txt_num.Location = New Point(84, 70)
        txt_num.Name = "txt_num"
        txt_num.Size = New Size(168, 27)
        txt_num.TabIndex = 9
        ' 
        ' txt_des
        ' 
        txt_des.Location = New Point(474, 70)
        txt_des.Name = "txt_des"
        txt_des.Size = New Size(152, 27)
        txt_des.TabIndex = 10
        ' 
        ' txt_prix
        ' 
        txt_prix.Location = New Point(297, 253)
        txt_prix.Name = "txt_prix"
        txt_prix.Size = New Size(166, 27)
        txt_prix.TabIndex = 11
        ' 
        ' txt_nbp
        ' 
        txt_nbp.Location = New Point(490, 185)
        txt_nbp.Name = "txt_nbp"
        txt_nbp.Size = New Size(164, 27)
        txt_nbp.TabIndex = 12
        ' 
        ' pick_dt
        ' 
        pick_dt.Location = New Point(55, 183)
        pick_dt.Name = "pick_dt"
        pick_dt.Size = New Size(231, 27)
        pick_dt.TabIndex = 13
        ' 
        ' dgv_vols
        ' 
        dgv_vols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vols.Columns.AddRange(New DataGridViewColumn() {Numero, Destination, Date_heure, nbplace, prix})
        dgv_vols.Location = New Point(691, 19)
        dgv_vols.Name = "dgv_vols"
        dgv_vols.RowHeadersWidth = 51
        dgv_vols.Size = New Size(642, 297)
        dgv_vols.TabIndex = 14
        ' 
        ' Numero
        ' 
        Numero.HeaderText = "Numero"
        Numero.MinimumWidth = 6
        Numero.Name = "Numero"
        Numero.Width = 125
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' Date_heure
        ' 
        Date_heure.HeaderText = "Date"
        Date_heure.MinimumWidth = 6
        Date_heure.Name = "Date_heure"
        Date_heure.Width = 125
        ' 
        ' nbplace
        ' 
        nbplace.HeaderText = "nombres places"
        nbplace.MinimumWidth = 6
        nbplace.Name = "nbplace"
        nbplace.Width = 125
        ' 
        ' prix
        ' 
        prix.HeaderText = "Prix"
        prix.MinimumWidth = 6
        prix.Name = "prix"
        prix.Width = 125
        ' 
        ' btn_deconnexion
        ' 
        btn_deconnexion.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        btn_deconnexion.ForeColor = SystemColors.ActiveCaption
        btn_deconnexion.Location = New Point(849, 334)
        btn_deconnexion.Name = "btn_deconnexion"
        btn_deconnexion.Size = New Size(173, 46)
        btn_deconnexion.TabIndex = 15
        btn_deconnexion.Text = "Déconnexion"
        btn_deconnexion.UseVisualStyleBackColor = True
        ' 
        ' formadmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(1345, 450)
        Controls.Add(btn_deconnexion)
        Controls.Add(dgv_vols)
        Controls.Add(pick_dt)
        Controls.Add(txt_nbp)
        Controls.Add(txt_prix)
        Controls.Add(txt_des)
        Controls.Add(txt_num)
        Controls.Add(lbl_prix)
        Controls.Add(lbl_nbp)
        Controls.Add(lbl_des)
        Controls.Add(lbl_time)
        Controls.Add(Label1)
        Controls.Add(lbl_num)
        Controls.Add(btn_supp)
        Controls.Add(btn_modif)
        Controls.Add(btn_ajout)
        Name = "formadmin"
        Text = "formadmin"
        CType(dgv_vols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_modif As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents lbl_num As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_des As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_places As Label
    Friend WithEvents lbl_prix As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_des As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_nbp As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_nbp As Label
    Friend WithEvents txt_prix As TextBox
    Friend WithEvents pick_dt As DateTimePicker
    Friend WithEvents dgv_vols As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents Date_heure As DataGridViewTextBoxColumn
    Friend WithEvents nbplace As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents btn_deconnexion As Button
End Class
