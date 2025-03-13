<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btn_piedra = New Button()
        btn_papel = New Button()
        btn_tijera = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        lbl_resultado = New Label()
        lbl_rachadevictorias = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_piedra
        ' 
        btn_piedra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_piedra.BackColor = SystemColors.ActiveCaptionText
        btn_piedra.Font = New Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_piedra.ForeColor = Color.White
        btn_piedra.ImageAlign = ContentAlignment.BottomCenter
        btn_piedra.Location = New Point(12, 424)
        btn_piedra.Name = "btn_piedra"
        btn_piedra.Size = New Size(234, 57)
        btn_piedra.TabIndex = 0
        btn_piedra.Text = "PIEDRA"
        btn_piedra.TextImageRelation = TextImageRelation.ImageAboveText
        btn_piedra.UseVisualStyleBackColor = False
        ' 
        ' btn_papel
        ' 
        btn_papel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_papel.BackColor = Color.Black
        btn_papel.Font = New Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_papel.ForeColor = Color.White
        btn_papel.ImageAlign = ContentAlignment.BottomCenter
        btn_papel.Location = New Point(392, 424)
        btn_papel.Name = "btn_papel"
        btn_papel.Size = New Size(234, 57)
        btn_papel.TabIndex = 1
        btn_papel.Text = "PAPEL"
        btn_papel.TextImageRelation = TextImageRelation.ImageAboveText
        btn_papel.UseVisualStyleBackColor = False
        ' 
        ' btn_tijera
        ' 
        btn_tijera.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_tijera.BackColor = Color.Black
        btn_tijera.Font = New Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_tijera.ForeColor = Color.White
        btn_tijera.ImageAlign = ContentAlignment.BottomCenter
        btn_tijera.Location = New Point(753, 424)
        btn_tijera.Name = "btn_tijera"
        btn_tijera.Size = New Size(234, 57)
        btn_tijera.TabIndex = 2
        btn_tijera.Text = "TIJERA"
        btn_tijera.TextImageRelation = TextImageRelation.ImageAboveText
        btn_tijera.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-20, 224)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(352, 395)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(288, 323)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(446, 189)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(673, 274)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(396, 324)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Viner Hand ITC", 24F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(286, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(427, 65)
        Label2.TabIndex = 8
        Label2.Text = "Piedra Papel o Tijeras"
        ' 
        ' lbl_resultado
        ' 
        lbl_resultado.AutoSize = True
        lbl_resultado.BackColor = SystemColors.ActiveCaptionText
        lbl_resultado.BorderStyle = BorderStyle.Fixed3D
        lbl_resultado.Font = New Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_resultado.ForeColor = Color.White
        lbl_resultado.Location = New Point(338, 85)
        lbl_resultado.Name = "lbl_resultado"
        lbl_resultado.Size = New Size(325, 57)
        lbl_resultado.TabIndex = 9
        lbl_resultado.Text = "Ganaste o Perdiste"
        lbl_resultado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_rachadevictorias
        ' 
        lbl_rachadevictorias.AutoSize = True
        lbl_rachadevictorias.BackColor = SystemColors.ActiveCaptionText
        lbl_rachadevictorias.BorderStyle = BorderStyle.Fixed3D
        lbl_rachadevictorias.Font = New Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_rachadevictorias.ForeColor = Color.White
        lbl_rachadevictorias.Location = New Point(338, 515)
        lbl_rachadevictorias.Name = "lbl_rachadevictorias"
        lbl_rachadevictorias.Size = New Size(333, 57)
        lbl_rachadevictorias.TabIndex = 10
        lbl_rachadevictorias.Text = "Racha de Victorias"
        lbl_rachadevictorias.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(999, 581)
        Controls.Add(lbl_rachadevictorias)
        Controls.Add(lbl_resultado)
        Controls.Add(Label2)
        Controls.Add(btn_tijera)
        Controls.Add(btn_papel)
        Controls.Add(btn_piedra)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_piedra As Button
    Friend WithEvents btn_papel As Button
    Friend WithEvents btn_tijera As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents lbl_rachadevictorias As Label

End Class
