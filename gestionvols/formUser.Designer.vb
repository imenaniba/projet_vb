<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUser
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
        lbl_des = New Label()
        lbl_date = New Label()
        lbl_tel = New Label()
        lbl_nom = New Label()
        Label5 = New Label()
        dgv_vols = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        dateheure = New DataGridViewTextBoxColumn()
        txt_des = New TextBox()
        txt_nom = New TextBox()
        txt_numtel = New TextBox()
        pick_date = New DateTimePicker()
        btn_rech = New Button()
        btn_res = New Button()
        lbl_pren = New Label()
        txt_prenom = New TextBox()
        btn_deconnexion = New Button()
        CType(dgv_vols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_des
        ' 
        lbl_des.AutoSize = True
        lbl_des.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_des.ForeColor = SystemColors.GradientActiveCaption
        lbl_des.Location = New Point(54, 104)
        lbl_des.Name = "lbl_des"
        lbl_des.Size = New Size(180, 41)
        lbl_des.TabIndex = 0
        lbl_des.Text = "Destination"
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_date.ForeColor = SystemColors.GradientActiveCaption
        lbl_date.Location = New Point(54, 197)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(211, 41)
        lbl_date.TabIndex = 1
        lbl_date.Text = "Date et heure"
        ' 
        ' lbl_tel
        ' 
        lbl_tel.AutoSize = True
        lbl_tel.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_tel.ForeColor = SystemColors.GradientActiveCaption
        lbl_tel.Location = New Point(54, 303)
        lbl_tel.Name = "lbl_tel"
        lbl_tel.Size = New Size(286, 41)
        lbl_tel.TabIndex = 2
        lbl_tel.Text = "Numéro téléphone"
        ' 
        ' lbl_nom
        ' 
        lbl_nom.AutoSize = True
        lbl_nom.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_nom.ForeColor = SystemColors.GradientActiveCaption
        lbl_nom.Location = New Point(54, 9)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(96, 41)
        lbl_nom.TabIndex = 3
        lbl_nom.Text = "Nom "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(142, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 4
        ' 
        ' dgv_vols
        ' 
        dgv_vols.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_vols.BorderStyle = BorderStyle.Fixed3D
        dgv_vols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vols.Columns.AddRange(New DataGridViewColumn() {Numero, Prix, Destination, dateheure})
        dgv_vols.GridColor = SystemColors.InactiveBorder
        dgv_vols.Location = New Point(592, 50)
        dgv_vols.Name = "dgv_vols"
        dgv_vols.RowHeadersWidth = 51
        dgv_vols.Size = New Size(554, 188)
        dgv_vols.TabIndex = 5
        ' 
        ' Numero
        ' 
        Numero.HeaderText = "Numero place"
        Numero.MinimumWidth = 6
        Numero.Name = "Numero"
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        ' 
        ' dateheure
        ' 
        dateheure.HeaderText = "Date et Heure"
        dateheure.MinimumWidth = 6
        dateheure.Name = "dateheure"
        ' 
        ' txt_des
        ' 
        txt_des.Location = New Point(54, 148)
        txt_des.Name = "txt_des"
        txt_des.Size = New Size(166, 27)
        txt_des.TabIndex = 6
        ' 
        ' txt_nom
        ' 
        txt_nom.Location = New Point(54, 63)
        txt_nom.Name = "txt_nom"
        txt_nom.Size = New Size(125, 27)
        txt_nom.TabIndex = 7
        ' 
        ' txt_numtel
        ' 
        txt_numtel.Location = New Point(54, 347)
        txt_numtel.Name = "txt_numtel"
        txt_numtel.Size = New Size(125, 27)
        txt_numtel.TabIndex = 8
        ' 
        ' pick_date
        ' 
        pick_date.Location = New Point(54, 246)
        pick_date.Name = "pick_date"
        pick_date.Size = New Size(250, 27)
        pick_date.TabIndex = 9
        ' 
        ' btn_rech
        ' 
        btn_rech.Font = New Font("Simplified Arabic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn_rech.ForeColor = SystemColors.ButtonShadow
        btn_rech.Location = New Point(272, 382)
        btn_rech.Name = "btn_rech"
        btn_rech.Size = New Size(190, 56)
        btn_rech.TabIndex = 10
        btn_rech.Text = "Rechercher"
        btn_rech.UseVisualStyleBackColor = True
        ' 
        ' btn_res
        ' 
        btn_res.Font = New Font("Simplified Arabic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn_res.ForeColor = SystemColors.ButtonShadow
        btn_res.Location = New Point(569, 382)
        btn_res.Name = "btn_res"
        btn_res.Size = New Size(185, 56)
        btn_res.TabIndex = 11
        btn_res.Text = "Réserver"
        btn_res.UseVisualStyleBackColor = True
        ' 
        ' lbl_pren
        ' 
        lbl_pren.AutoSize = True
        lbl_pren.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_pren.ForeColor = SystemColors.GradientActiveCaption
        lbl_pren.Location = New Point(346, 9)
        lbl_pren.Name = "lbl_pren"
        lbl_pren.Size = New Size(128, 41)
        lbl_pren.TabIndex = 12
        lbl_pren.Text = "Prénom"
        ' 
        ' txt_prenom
        ' 
        txt_prenom.Location = New Point(349, 63)
        txt_prenom.Name = "txt_prenom"
        txt_prenom.Size = New Size(125, 27)
        txt_prenom.TabIndex = 13
        ' 
        ' btn_deconnexion
        ' 
        btn_deconnexion.Font = New Font("Simplified Arabic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn_deconnexion.ForeColor = SystemColors.ButtonShadow
        btn_deconnexion.Location = New Point(820, 382)
        btn_deconnexion.Name = "btn_deconnexion"
        btn_deconnexion.Size = New Size(215, 56)
        btn_deconnexion.TabIndex = 14
        btn_deconnexion.Text = "Déconnexion"
        btn_deconnexion.UseVisualStyleBackColor = True
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(1171, 450)
        Controls.Add(btn_deconnexion)
        Controls.Add(txt_prenom)
        Controls.Add(lbl_pren)
        Controls.Add(btn_res)
        Controls.Add(btn_rech)
        Controls.Add(pick_date)
        Controls.Add(txt_numtel)
        Controls.Add(txt_nom)
        Controls.Add(txt_des)
        Controls.Add(dgv_vols)
        Controls.Add(Label5)
        Controls.Add(lbl_nom)
        Controls.Add(lbl_tel)
        Controls.Add(lbl_date)
        Controls.Add(lbl_des)
        Name = "FormUser"
        Text = "formUser"
        CType(dgv_vols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_des As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_vols As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents dateheure As DataGridViewTextBoxColumn
    Friend WithEvents txt_des As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_numtel As TextBox
    Friend WithEvents pick_date As DateTimePicker
    Friend WithEvents btn_rech As Button
    Friend WithEvents btn_res As Button
    Friend WithEvents lbl_pren As Label
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_deconnexion As Button


End Class
