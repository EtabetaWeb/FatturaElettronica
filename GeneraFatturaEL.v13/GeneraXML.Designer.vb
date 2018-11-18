<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneraXML
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneraXML))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPercorsoFile = New System.Windows.Forms.TextBox()
        Me.BtnEseguiCodice = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPercorsoFile)
        Me.GroupBox1.Controls.Add(Me.BtnEseguiCodice)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 447)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informazioni preliminari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Percorso e nome del file XML generato"
        '
        'TxtPercorsoFile
        '
        Me.TxtPercorsoFile.Location = New System.Drawing.Point(6, 417)
        Me.TxtPercorsoFile.Name = "TxtPercorsoFile"
        Me.TxtPercorsoFile.Size = New System.Drawing.Size(516, 20)
        Me.TxtPercorsoFile.TabIndex = 2
        '
        'BtnEseguiCodice
        '
        Me.BtnEseguiCodice.Location = New System.Drawing.Point(2, 360)
        Me.BtnEseguiCodice.Name = "BtnEseguiCodice"
        Me.BtnEseguiCodice.Size = New System.Drawing.Size(520, 23)
        Me.BtnEseguiCodice.TabIndex = 1
        Me.BtnEseguiCodice.Text = "ESEGUI IL CODICE"
        Me.BtnEseguiCodice.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(515, 320)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GeneraXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GeneraXML"
        Me.Text = "GeneraXML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEseguiCodice As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TxtPercorsoFile As TextBox
    Friend WithEvents Label1 As Label
End Class
