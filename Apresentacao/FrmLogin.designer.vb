<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>

Partial Class Apresentacao
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txbSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.lblSenha = New System.Windows.Forms.LinkLabel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnFechar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 330)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sentinela_v1._0.My.Resources.Resources.marca
        Me.PictureBox3.Location = New System.Drawing.Point(56, 104)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(134, 92)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(304, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 7)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "_________________________________________________________________________________" &
    "_____________________________________________________"
        '
        'txbUsuario
        '
        Me.txbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.txbUsuario.Location = New System.Drawing.Point(304, 111)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(404, 20)
        Me.txbUsuario.TabIndex = 1
        Me.txbUsuario.Text = "USUÁRIO"
        '
        'txbSenha
        '
        Me.txbSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbSenha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSenha.ForeColor = System.Drawing.Color.DimGray
        Me.txbSenha.Location = New System.Drawing.Point(304, 166)
        Me.txbSenha.Name = "txbSenha"
        Me.txbSenha.Size = New System.Drawing.Size(404, 20)
        Me.txbSenha.TabIndex = 2
        Me.txbSenha.Text = "SENHA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(304, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(406, 7)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "_________________________________________________________________________________" &
    "_____________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(474, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LOGIN"
        '
        'btnAcessar
        '
        Me.btnAcessar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcessar.ForeColor = System.Drawing.Color.LightGray
        Me.btnAcessar.Location = New System.Drawing.Point(304, 231)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(404, 40)
        Me.btnAcessar.TabIndex = 3
        Me.btnAcessar.Text = "ACESSAR"
        Me.btnAcessar.UseVisualStyleBackColor = True
        '
        'lblSenha
        '
        Me.lblSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.LinkColor = System.Drawing.Color.DimGray
        Me.lblSenha.Location = New System.Drawing.Point(422, 274)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(171, 17)
        Me.lblSenha.TabIndex = 0
        Me.lblSenha.TabStop = True
        Me.lblSenha.Text = "Recuperar senha perdida"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(724, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 9
        Me.btnMinimizar.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_cerrar2
        Me.btnFechar.Location = New System.Drawing.Point(743, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(15, 15)
        Me.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFechar.TabIndex = 8
        Me.btnFechar.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 330)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.btnAcessar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbSenha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAcessar As Button
    Friend WithEvents lblSenha As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnFechar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
