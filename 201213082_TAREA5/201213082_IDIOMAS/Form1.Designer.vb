<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCarne = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Lbcarné = New System.Windows.Forms.Label()
        Me.Lbnombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txthoras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbsabado = New System.Windows.Forms.CheckBox()
        Me.Cbviernes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Cbidiomas = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbcheque = New System.Windows.Forms.RadioButton()
        Me.Rbefectivo = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bttcalcular = New System.Windows.Forms.Button()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.Btsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCarne)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Lbcarné)
        Me.GroupBox1.Controls.Add(Me.Lbnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del estudiante"
        '
        'TxtCarne
        '
        Me.TxtCarne.Location = New System.Drawing.Point(25, 196)
        Me.TxtCarne.Name = "TxtCarne"
        Me.TxtCarne.Size = New System.Drawing.Size(218, 27)
        Me.TxtCarne.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(25, 81)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(217, 27)
        Me.TxtNombre.TabIndex = 2
        '
        'Lbcarné
        '
        Me.Lbcarné.AutoSize = True
        Me.Lbcarné.Location = New System.Drawing.Point(25, 151)
        Me.Lbcarné.Name = "Lbcarné"
        Me.Lbcarné.Size = New System.Drawing.Size(95, 20)
        Me.Lbcarné.TabIndex = 1
        Me.Lbcarné.Text = "No. de Carné"
        '
        'Lbnombre
        '
        Me.Lbnombre.AutoSize = True
        Me.Lbnombre.Location = New System.Drawing.Point(13, 35)
        Me.Lbnombre.Name = "Lbnombre"
        Me.Lbnombre.Size = New System.Drawing.Size(64, 20)
        Me.Lbnombre.TabIndex = 0
        Me.Lbnombre.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txthoras)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Cbsabado)
        Me.GroupBox2.Controls.Add(Me.Cbviernes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Dtfecha)
        Me.GroupBox2.Controls.Add(Me.Cbidiomas)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 289)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del curso"
        '
        'Txthoras
        '
        Me.Txthoras.Location = New System.Drawing.Point(162, 227)
        Me.Txthoras.Name = "Txthoras"
        Me.Txthoras.Size = New System.Drawing.Size(104, 27)
        Me.Txthoras.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Horas"
        '
        'Cbsabado
        '
        Me.Cbsabado.AutoSize = True
        Me.Cbsabado.Location = New System.Drawing.Point(11, 254)
        Me.Cbsabado.Name = "Cbsabado"
        Me.Cbsabado.Size = New System.Drawing.Size(82, 24)
        Me.Cbsabado.TabIndex = 8
        Me.Cbsabado.Text = "Sábado"
        Me.Cbsabado.UseVisualStyleBackColor = True
        '
        'Cbviernes
        '
        Me.Cbviernes.AutoSize = True
        Me.Cbviernes.Location = New System.Drawing.Point(12, 220)
        Me.Cbviernes.Name = "Cbviernes"
        Me.Cbviernes.Size = New System.Drawing.Size(79, 24)
        Me.Cbviernes.TabIndex = 7
        Me.Cbviernes.Text = "Viernes"
        Me.Cbviernes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Días "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de inscipción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Idioma"
        '
        'Dtfecha
        '
        Me.Dtfecha.Location = New System.Drawing.Point(5, 146)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(260, 27)
        Me.Dtfecha.TabIndex = 3
        '
        'Cbidiomas
        '
        Me.Cbidiomas.FormattingEnabled = True
        Me.Cbidiomas.Items.AddRange(New Object() {"Inglés ", "Portugués", "Francés "})
        Me.Cbidiomas.Location = New System.Drawing.Point(6, 68)
        Me.Cbidiomas.Name = "Cbidiomas"
        Me.Cbidiomas.Size = New System.Drawing.Size(260, 28)
        Me.Cbidiomas.TabIndex = 0
        Me.Cbidiomas.Text = "Seleccionar un idioma"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbcheque)
        Me.GroupBox3.Controls.Add(Me.Rbefectivo)
        Me.GroupBox3.Location = New System.Drawing.Point(820, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 151)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de pago"
        '
        'Rbcheque
        '
        Me.Rbcheque.AutoSize = True
        Me.Rbcheque.Location = New System.Drawing.Point(15, 97)
        Me.Rbcheque.Name = "Rbcheque"
        Me.Rbcheque.Size = New System.Drawing.Size(80, 24)
        Me.Rbcheque.TabIndex = 1
        Me.Rbcheque.TabStop = True
        Me.Rbcheque.Text = "Cheque"
        Me.Rbcheque.UseVisualStyleBackColor = True
        '
        'Rbefectivo
        '
        Me.Rbefectivo.AutoSize = True
        Me.Rbefectivo.Location = New System.Drawing.Point(15, 48)
        Me.Rbefectivo.Name = "Rbefectivo"
        Me.Rbefectivo.Size = New System.Drawing.Size(83, 24)
        Me.Rbefectivo.TabIndex = 0
        Me.Rbefectivo.TabStop = True
        Me.Rbefectivo.Text = "Efectivo"
        Me.Rbefectivo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 367)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1310, 188)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Registro "
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carné"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Idioma"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fecha de inscripción"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Días del curso "
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Horas"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Método de pago"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Pago parcial "
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "Descuento 1"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "Descuento 2"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "Pago final "
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Bttcalcular
        '
        Me.Bttcalcular.Location = New System.Drawing.Point(1106, 88)
        Me.Bttcalcular.Name = "Bttcalcular"
        Me.Bttcalcular.Size = New System.Drawing.Size(94, 29)
        Me.Bttcalcular.TabIndex = 4
        Me.Bttcalcular.Text = "Calcular"
        Me.Bttcalcular.UseVisualStyleBackColor = True
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(1106, 147)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(94, 29)
        Me.Btlimpiar.TabIndex = 5
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'Btsalir
        '
        Me.Btsalir.Location = New System.Drawing.Point(1106, 211)
        Me.Btsalir.Name = "Btsalir"
        Me.Btsalir.Size = New System.Drawing.Size(94, 29)
        Me.Btsalir.TabIndex = 6
        Me.Btsalir.Text = "Salir"
        Me.Btsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1395, 571)
        Me.Controls.Add(Me.Btsalir)
        Me.Controls.Add(Me.Btlimpiar)
        Me.Controls.Add(Me.Bttcalcular)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCarne As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Lbcarné As Label
    Friend WithEvents Lbnombre As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cbidiomas As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txthoras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbsabado As CheckBox
    Friend WithEvents Cbviernes As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtfecha As DateTimePicker
    Friend WithEvents Rbcheque As RadioButton
    Friend WithEvents Rbefectivo As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bttcalcular As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents Btsalir As Button
End Class
