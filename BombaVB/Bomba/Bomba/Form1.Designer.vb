<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBombaVB
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBombaVB))
        Me.lblTexto1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.lblMilis = New System.Windows.Forms.Label()
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.lblPuntos1 = New System.Windows.Forms.Label()
        Me.lblPuntos2 = New System.Windows.Forms.Label()
        Me.pbxBomba = New System.Windows.Forms.PictureBox()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.pbxBomba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTexto1
        '
        Me.lblTexto1.AutoSize = True
        Me.lblTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto1.Location = New System.Drawing.Point(513, 38)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Size = New System.Drawing.Size(62, 13)
        Me.lblTexto1.TabIndex = 0
        Me.lblTexto1.Text = "Passcode"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(495, 54)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(90, 20)
        Me.txtPass.TabIndex = 1
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutos.Location = New System.Drawing.Point(117, 312)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(68, 48)
        Me.lblMinutos.TabIndex = 3
        Me.lblMinutos.Text = "02"
        '
        'lblSegundos
        '
        Me.lblSegundos.AutoSize = True
        Me.lblSegundos.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 36.0!)
        Me.lblSegundos.Location = New System.Drawing.Point(241, 312)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(68, 48)
        Me.lblSegundos.TabIndex = 4
        Me.lblSegundos.Text = "00"
        '
        'lblMilis
        '
        Me.lblMilis.AutoSize = True
        Me.lblMilis.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 36.0!)
        Me.lblMilis.Location = New System.Drawing.Point(357, 312)
        Me.lblMilis.Name = "lblMilis"
        Me.lblMilis.Size = New System.Drawing.Size(68, 48)
        Me.lblMilis.TabIndex = 5
        Me.lblMilis.Text = "00"
        '
        'tmrTiempo
        '
        Me.tmrTiempo.Enabled = True
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAzul.Location = New System.Drawing.Point(563, 99)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 6
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'lblPuntos1
        '
        Me.lblPuntos1.AutoSize = True
        Me.lblPuntos1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 36.0!)
        Me.lblPuntos1.Location = New System.Drawing.Point(191, 312)
        Me.lblPuntos1.Name = "lblPuntos1"
        Me.lblPuntos1.Size = New System.Drawing.Size(44, 48)
        Me.lblPuntos1.TabIndex = 8
        Me.lblPuntos1.Text = ":"
        '
        'lblPuntos2
        '
        Me.lblPuntos2.AutoSize = True
        Me.lblPuntos2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 36.0!)
        Me.lblPuntos2.Location = New System.Drawing.Point(315, 312)
        Me.lblPuntos2.Name = "lblPuntos2"
        Me.lblPuntos2.Size = New System.Drawing.Size(44, 48)
        Me.lblPuntos2.TabIndex = 9
        Me.lblPuntos2.Text = ":"
        '
        'pbxBomba
        '
        Me.pbxBomba.Image = Global.Bomba.My.Resources.Resources._1
        Me.pbxBomba.Location = New System.Drawing.Point(47, 23)
        Me.pbxBomba.Name = "pbxBomba"
        Me.pbxBomba.Size = New System.Drawing.Size(378, 274)
        Me.pbxBomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxBomba.TabIndex = 7
        Me.pbxBomba.TabStop = False
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRojo.BackgroundImage = CType(resources.GetObject("btnRojo.BackgroundImage"), System.Drawing.Image)
        Me.btnRojo.Location = New System.Drawing.Point(452, 99)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 2
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(484, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'frmBombaVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(677, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblPuntos2)
        Me.Controls.Add(Me.lblPuntos1)
        Me.Controls.Add(Me.pbxBomba)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.lblMilis)
        Me.Controls.Add(Me.lblSegundos)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblTexto1)
        Me.Name = "frmBombaVB"
        Me.Text = "Bomba"
        CType(Me.pbxBomba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexto1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnRojo As Button
    Friend WithEvents lblMinutos As Label
    Friend WithEvents lblSegundos As Label
    Friend WithEvents lblMilis As Label
    Friend WithEvents tmrTiempo As Timer
    Friend WithEvents btnAzul As Button
    Friend WithEvents pbxBomba As PictureBox
    Friend WithEvents lblPuntos1 As Label
    Friend WithEvents lblPuntos2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
