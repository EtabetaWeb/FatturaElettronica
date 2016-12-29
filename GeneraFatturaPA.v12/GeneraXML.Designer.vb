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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtNomeFile = New System.Windows.Forms.TextBox()
        Me.btn_crea_xml = New System.Windows.Forms.Button()
        Me.txtPercorso = New System.Windows.Forms.TextBox()
        Me.lblNomeFile = New System.Windows.Forms.Label()
        Me.lblPercorso = New System.Windows.Forms.Label()
        Me.txtMessaggio = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNomeFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_crea_xml)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPercorso)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNomeFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPercorso)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtMessaggio)
        Me.SplitContainer1.Size = New System.Drawing.Size(851, 100)
        Me.SplitContainer1.SplitterDistance = 71
        Me.SplitContainer1.TabIndex = 23
        '
        'txtNomeFile
        '
        Me.txtNomeFile.Location = New System.Drawing.Point(471, 35)
        Me.txtNomeFile.Name = "txtNomeFile"
        Me.txtNomeFile.Size = New System.Drawing.Size(217, 20)
        Me.txtNomeFile.TabIndex = 20
        '
        'btn_crea_xml
        '
        Me.btn_crea_xml.Location = New System.Drawing.Point(697, 35)
        Me.btn_crea_xml.Name = "btn_crea_xml"
        Me.btn_crea_xml.Size = New System.Drawing.Size(120, 23)
        Me.btn_crea_xml.TabIndex = 16
        Me.btn_crea_xml.Text = "Genera file XML"
        Me.btn_crea_xml.UseVisualStyleBackColor = True
        '
        'txtPercorso
        '
        Me.txtPercorso.Location = New System.Drawing.Point(14, 35)
        Me.txtPercorso.Name = "txtPercorso"
        Me.txtPercorso.Size = New System.Drawing.Size(451, 20)
        Me.txtPercorso.TabIndex = 18
        '
        'lblNomeFile
        '
        Me.lblNomeFile.AutoSize = True
        Me.lblNomeFile.Location = New System.Drawing.Point(468, 19)
        Me.lblNomeFile.Name = "lblNomeFile"
        Me.lblNomeFile.Size = New System.Drawing.Size(54, 13)
        Me.lblNomeFile.TabIndex = 19
        Me.lblNomeFile.Text = "Nome File"
        '
        'lblPercorso
        '
        Me.lblPercorso.AutoSize = True
        Me.lblPercorso.Location = New System.Drawing.Point(14, 19)
        Me.lblPercorso.Name = "lblPercorso"
        Me.lblPercorso.Size = New System.Drawing.Size(111, 13)
        Me.lblPercorso.TabIndex = 17
        Me.lblPercorso.Text = "Percorso (es: c:\dati\)"
        '
        'txtMessaggio
        '
        Me.txtMessaggio.Location = New System.Drawing.Point(14, 29)
        Me.txtMessaggio.Name = "txtMessaggio"
        Me.txtMessaggio.Size = New System.Drawing.Size(803, 20)
        Me.txtMessaggio.TabIndex = 21
        '
        'GeneraXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 100)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GeneraXML"
        Me.Text = "Fattura Elettronica | Genera Xml v1.2"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtNomeFile As TextBox
    Friend WithEvents btn_crea_xml As Button
    Friend WithEvents txtPercorso As TextBox
    Friend WithEvents lblNomeFile As Label
    Friend WithEvents lblPercorso As Label
    Friend WithEvents txtMessaggio As TextBox
End Class
