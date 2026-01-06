<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetUp))
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txtCOM = New System.Windows.Forms.TextBox()
        Me.txtSession = New System.Windows.Forms.TextBox()
        Me.lblSesion = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblSujeto = New System.Windows.Forms.Label()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.rdoConcurrent = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbRefs = New System.Windows.Forms.TextBox()
        Me.grpSimple = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbValS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoFIS2 = New System.Windows.Forms.RadioButton()
        Me.rdoFIS1 = New System.Windows.Forms.RadioButton()
        Me.rdoVIS2 = New System.Windows.Forms.RadioButton()
        Me.rdoVIS1 = New System.Windows.Forms.RadioButton()
        Me.rdoVRS2 = New System.Windows.Forms.RadioButton()
        Me.rdoVRS1 = New System.Windows.Forms.RadioButton()
        Me.rdoFRS2 = New System.Windows.Forms.RadioButton()
        Me.rdoFRS1 = New System.Windows.Forms.RadioButton()
        Me.grpConcurrent = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoFIC2 = New System.Windows.Forms.RadioButton()
        Me.txbValCP2 = New System.Windows.Forms.TextBox()
        Me.rdoVIC2 = New System.Windows.Forms.RadioButton()
        Me.rdoVRC2 = New System.Windows.Forms.RadioButton()
        Me.rdoFRC2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoFIC1 = New System.Windows.Forms.RadioButton()
        Me.txbValCP1 = New System.Windows.Forms.TextBox()
        Me.rdoVIC1 = New System.Windows.Forms.RadioButton()
        Me.rdoVRC1 = New System.Windows.Forms.RadioButton()
        Me.rdoFRC1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.grpSimple.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpConcurrent.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(16, 250)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(149, 128)
        Me.btnComenzar.TabIndex = 0
        Me.btnComenzar.Text = "Start"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtCOM
        '
        Me.txtCOM.Location = New System.Drawing.Point(76, 60)
        Me.txtCOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCOM.Name = "txtCOM"
        Me.txtCOM.Size = New System.Drawing.Size(89, 22)
        Me.txtCOM.TabIndex = 3
        Me.txtCOM.Text = "COM4"
        '
        'txtSession
        '
        Me.txtSession.Location = New System.Drawing.Point(76, 36)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(89, 22)
        Me.txtSession.TabIndex = 2
        Me.txtSession.Text = "1"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(12, 38)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(59, 16)
        Me.lblSesion.TabIndex = 5
        Me.lblSesion.Text = "Session:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(76, 10)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(89, 22)
        Me.txtSubject.TabIndex = 1
        Me.txtSubject.Text = "TEST"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(14, 64)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(34, 16)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Port:"
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Location = New System.Drawing.Point(14, 12)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(55, 16)
        Me.lblSujeto.TabIndex = 4
        Me.lblSujeto.Text = "Subject:"
        '
        'rdoSimple
        '
        Me.rdoSimple.AutoSize = True
        Me.rdoSimple.Location = New System.Drawing.Point(23, 20)
        Me.rdoSimple.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(70, 20)
        Me.rdoSimple.TabIndex = 7
        Me.rdoSimple.TabStop = True
        Me.rdoSimple.Text = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'rdoConcurrent
        '
        Me.rdoConcurrent.AutoSize = True
        Me.rdoConcurrent.Location = New System.Drawing.Point(23, 44)
        Me.rdoConcurrent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoConcurrent.Name = "rdoConcurrent"
        Me.rdoConcurrent.Size = New System.Drawing.Size(92, 20)
        Me.rdoConcurrent.TabIndex = 8
        Me.rdoConcurrent.TabStop = True
        Me.rdoConcurrent.Text = "Concurrent"
        Me.rdoConcurrent.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rdoSimple)
        Me.GroupBox1.Controls.Add(Me.txbRefs)
        Me.GroupBox1.Controls.Add(Me.rdoConcurrent)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(142, 104)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schedule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Refs:"
        '
        'txbRefs
        '
        Me.txbRefs.Location = New System.Drawing.Point(48, 75)
        Me.txbRefs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbRefs.Name = "txbRefs"
        Me.txbRefs.Size = New System.Drawing.Size(89, 22)
        Me.txbRefs.TabIndex = 15
        Me.txbRefs.Text = "30"
        '
        'grpSimple
        '
        Me.grpSimple.Controls.Add(Me.GroupBox4)
        Me.grpSimple.Location = New System.Drawing.Point(192, 10)
        Me.grpSimple.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSimple.Name = "grpSimple"
        Me.grpSimple.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSimple.Size = New System.Drawing.Size(387, 185)
        Me.grpSimple.TabIndex = 11
        Me.grpSimple.TabStop = False
        Me.grpSimple.Text = "Simple"
        Me.grpSimple.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txbValS)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.rdoFIS2)
        Me.GroupBox4.Controls.Add(Me.rdoFIS1)
        Me.GroupBox4.Controls.Add(Me.rdoVIS2)
        Me.GroupBox4.Controls.Add(Me.rdoVIS1)
        Me.GroupBox4.Controls.Add(Me.rdoVRS2)
        Me.GroupBox4.Controls.Add(Me.rdoVRS1)
        Me.GroupBox4.Controls.Add(Me.rdoFRS2)
        Me.GroupBox4.Controls.Add(Me.rdoFRS1)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(372, 158)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lever 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Value:"
        '
        'txbValS
        '
        Me.txbValS.Location = New System.Drawing.Point(133, 128)
        Me.txbValS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbValS.Name = "txbValS"
        Me.txbValS.Size = New System.Drawing.Size(113, 22)
        Me.txbValS.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lever 2"
        '
        'rdoFIS2
        '
        Me.rdoFIS2.AutoSize = True
        Me.rdoFIS2.Location = New System.Drawing.Point(215, 78)
        Me.rdoFIS2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFIS2.Name = "rdoFIS2"
        Me.rdoFIS2.Size = New System.Drawing.Size(107, 20)
        Me.rdoFIS2.TabIndex = 9
        Me.rdoFIS2.TabStop = True
        Me.rdoFIS2.Text = "Fixed Interval"
        Me.rdoFIS2.UseVisualStyleBackColor = True
        '
        'rdoFIS1
        '
        Me.rdoFIS1.AutoSize = True
        Me.rdoFIS1.Location = New System.Drawing.Point(25, 78)
        Me.rdoFIS1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFIS1.Name = "rdoFIS1"
        Me.rdoFIS1.Size = New System.Drawing.Size(107, 20)
        Me.rdoFIS1.TabIndex = 9
        Me.rdoFIS1.TabStop = True
        Me.rdoFIS1.Text = "Fixed Interval"
        Me.rdoFIS1.UseVisualStyleBackColor = True
        '
        'rdoVIS2
        '
        Me.rdoVIS2.AutoSize = True
        Me.rdoVIS2.Location = New System.Drawing.Point(215, 102)
        Me.rdoVIS2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVIS2.Name = "rdoVIS2"
        Me.rdoVIS2.Size = New System.Drawing.Size(125, 20)
        Me.rdoVIS2.TabIndex = 10
        Me.rdoVIS2.TabStop = True
        Me.rdoVIS2.Text = "Variable Interval"
        Me.rdoVIS2.UseVisualStyleBackColor = True
        '
        'rdoVIS1
        '
        Me.rdoVIS1.AutoSize = True
        Me.rdoVIS1.Location = New System.Drawing.Point(25, 102)
        Me.rdoVIS1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVIS1.Name = "rdoVIS1"
        Me.rdoVIS1.Size = New System.Drawing.Size(125, 20)
        Me.rdoVIS1.TabIndex = 10
        Me.rdoVIS1.TabStop = True
        Me.rdoVIS1.Text = "Variable Interval"
        Me.rdoVIS1.UseVisualStyleBackColor = True
        '
        'rdoVRS2
        '
        Me.rdoVRS2.AutoSize = True
        Me.rdoVRS2.Location = New System.Drawing.Point(215, 54)
        Me.rdoVRS2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVRS2.Name = "rdoVRS2"
        Me.rdoVRS2.Size = New System.Drawing.Size(114, 20)
        Me.rdoVRS2.TabIndex = 8
        Me.rdoVRS2.TabStop = True
        Me.rdoVRS2.Text = "Variable Ratio"
        Me.rdoVRS2.UseVisualStyleBackColor = True
        '
        'rdoVRS1
        '
        Me.rdoVRS1.AutoSize = True
        Me.rdoVRS1.Location = New System.Drawing.Point(25, 54)
        Me.rdoVRS1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVRS1.Name = "rdoVRS1"
        Me.rdoVRS1.Size = New System.Drawing.Size(114, 20)
        Me.rdoVRS1.TabIndex = 8
        Me.rdoVRS1.TabStop = True
        Me.rdoVRS1.Text = "Variable Ratio"
        Me.rdoVRS1.UseVisualStyleBackColor = True
        '
        'rdoFRS2
        '
        Me.rdoFRS2.AutoSize = True
        Me.rdoFRS2.Location = New System.Drawing.Point(215, 30)
        Me.rdoFRS2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFRS2.Name = "rdoFRS2"
        Me.rdoFRS2.Size = New System.Drawing.Size(96, 20)
        Me.rdoFRS2.TabIndex = 7
        Me.rdoFRS2.TabStop = True
        Me.rdoFRS2.Text = "Fixed Ratio"
        Me.rdoFRS2.UseVisualStyleBackColor = True
        '
        'rdoFRS1
        '
        Me.rdoFRS1.AutoSize = True
        Me.rdoFRS1.Location = New System.Drawing.Point(25, 30)
        Me.rdoFRS1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFRS1.Name = "rdoFRS1"
        Me.rdoFRS1.Size = New System.Drawing.Size(96, 20)
        Me.rdoFRS1.TabIndex = 7
        Me.rdoFRS1.TabStop = True
        Me.rdoFRS1.Text = "Fixed Ratio"
        Me.rdoFRS1.UseVisualStyleBackColor = True
        '
        'grpConcurrent
        '
        Me.grpConcurrent.Controls.Add(Me.GroupBox6)
        Me.grpConcurrent.Controls.Add(Me.GroupBox7)
        Me.grpConcurrent.Location = New System.Drawing.Point(192, 199)
        Me.grpConcurrent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConcurrent.Name = "grpConcurrent"
        Me.grpConcurrent.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConcurrent.Size = New System.Drawing.Size(387, 185)
        Me.grpConcurrent.TabIndex = 14
        Me.grpConcurrent.TabStop = False
        Me.grpConcurrent.Text = "Concurrent"
        Me.grpConcurrent.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.rdoFIC2)
        Me.GroupBox6.Controls.Add(Me.txbValCP2)
        Me.GroupBox6.Controls.Add(Me.rdoVIC2)
        Me.GroupBox6.Controls.Add(Me.rdoVRC2)
        Me.GroupBox6.Controls.Add(Me.rdoFRC2)
        Me.GroupBox6.Location = New System.Drawing.Point(199, 21)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(183, 158)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lever 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Value:"
        '
        'rdoFIC2
        '
        Me.rdoFIC2.AutoSize = True
        Me.rdoFIC2.Location = New System.Drawing.Point(25, 78)
        Me.rdoFIC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFIC2.Name = "rdoFIC2"
        Me.rdoFIC2.Size = New System.Drawing.Size(107, 20)
        Me.rdoFIC2.TabIndex = 9
        Me.rdoFIC2.TabStop = True
        Me.rdoFIC2.Text = "Fixed Interval"
        Me.rdoFIC2.UseVisualStyleBackColor = True
        '
        'txbValCP2
        '
        Me.txbValCP2.Location = New System.Drawing.Point(61, 128)
        Me.txbValCP2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbValCP2.Name = "txbValCP2"
        Me.txbValCP2.Size = New System.Drawing.Size(113, 22)
        Me.txbValCP2.TabIndex = 15
        '
        'rdoVIC2
        '
        Me.rdoVIC2.AutoSize = True
        Me.rdoVIC2.Location = New System.Drawing.Point(25, 102)
        Me.rdoVIC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVIC2.Name = "rdoVIC2"
        Me.rdoVIC2.Size = New System.Drawing.Size(125, 20)
        Me.rdoVIC2.TabIndex = 10
        Me.rdoVIC2.TabStop = True
        Me.rdoVIC2.Text = "Variable Interval"
        Me.rdoVIC2.UseVisualStyleBackColor = True
        '
        'rdoVRC2
        '
        Me.rdoVRC2.AutoSize = True
        Me.rdoVRC2.Location = New System.Drawing.Point(25, 54)
        Me.rdoVRC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVRC2.Name = "rdoVRC2"
        Me.rdoVRC2.Size = New System.Drawing.Size(114, 20)
        Me.rdoVRC2.TabIndex = 8
        Me.rdoVRC2.TabStop = True
        Me.rdoVRC2.Text = "Variable Ratio"
        Me.rdoVRC2.UseVisualStyleBackColor = True
        '
        'rdoFRC2
        '
        Me.rdoFRC2.AutoSize = True
        Me.rdoFRC2.Location = New System.Drawing.Point(25, 30)
        Me.rdoFRC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFRC2.Name = "rdoFRC2"
        Me.rdoFRC2.Size = New System.Drawing.Size(96, 20)
        Me.rdoFRC2.TabIndex = 7
        Me.rdoFRC2.TabStop = True
        Me.rdoFRC2.Text = "Fixed Ratio"
        Me.rdoFRC2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.rdoFIC1)
        Me.GroupBox7.Controls.Add(Me.txbValCP1)
        Me.GroupBox7.Controls.Add(Me.rdoVIC1)
        Me.GroupBox7.Controls.Add(Me.rdoVRC1)
        Me.GroupBox7.Controls.Add(Me.rdoFRC1)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 21)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(183, 158)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Lever 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Value:"
        '
        'rdoFIC1
        '
        Me.rdoFIC1.AutoSize = True
        Me.rdoFIC1.Location = New System.Drawing.Point(25, 78)
        Me.rdoFIC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFIC1.Name = "rdoFIC1"
        Me.rdoFIC1.Size = New System.Drawing.Size(107, 20)
        Me.rdoFIC1.TabIndex = 9
        Me.rdoFIC1.TabStop = True
        Me.rdoFIC1.Text = "Fixed Interval"
        Me.rdoFIC1.UseVisualStyleBackColor = True
        '
        'txbValCP1
        '
        Me.txbValCP1.Location = New System.Drawing.Point(61, 128)
        Me.txbValCP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbValCP1.Name = "txbValCP1"
        Me.txbValCP1.Size = New System.Drawing.Size(113, 22)
        Me.txbValCP1.TabIndex = 13
        '
        'rdoVIC1
        '
        Me.rdoVIC1.AutoSize = True
        Me.rdoVIC1.Location = New System.Drawing.Point(25, 102)
        Me.rdoVIC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVIC1.Name = "rdoVIC1"
        Me.rdoVIC1.Size = New System.Drawing.Size(125, 20)
        Me.rdoVIC1.TabIndex = 10
        Me.rdoVIC1.TabStop = True
        Me.rdoVIC1.Text = "Variable Interval"
        Me.rdoVIC1.UseVisualStyleBackColor = True
        '
        'rdoVRC1
        '
        Me.rdoVRC1.AutoSize = True
        Me.rdoVRC1.Location = New System.Drawing.Point(25, 54)
        Me.rdoVRC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoVRC1.Name = "rdoVRC1"
        Me.rdoVRC1.Size = New System.Drawing.Size(114, 20)
        Me.rdoVRC1.TabIndex = 8
        Me.rdoVRC1.TabStop = True
        Me.rdoVRC1.Text = "Variable Ratio"
        Me.rdoVRC1.UseVisualStyleBackColor = True
        '
        'rdoFRC1
        '
        Me.rdoFRC1.AutoSize = True
        Me.rdoFRC1.Location = New System.Drawing.Point(25, 30)
        Me.rdoFRC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFRC1.Name = "rdoFRC1"
        Me.rdoFRC1.Size = New System.Drawing.Size(96, 20)
        Me.rdoFRC1.TabIndex = 7
        Me.rdoFRC1.TabStop = True
        Me.rdoFRC1.Text = "Fixed Ratio"
        Me.rdoFRC1.UseVisualStyleBackColor = True
        '
        'SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 400)
        Me.Controls.Add(Me.grpConcurrent)
        Me.Controls.Add(Me.grpSimple)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSesion)
        Me.Controls.Add(Me.txtCOM)
        Me.Controls.Add(Me.txtSession)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SetUp"
        Me.Text = "Reinforcement Schedules"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpSimple.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpConcurrent.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComenzar As Button
    Friend WithEvents txtCOM As TextBox
    Friend WithEvents txtSession As TextBox
    Friend WithEvents lblSesion As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents lblSujeto As Label
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents rdoConcurrent As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpSimple As GroupBox
    Friend WithEvents rdoFIS2 As RadioButton
    Friend WithEvents rdoVIS2 As RadioButton
    Friend WithEvents rdoVRS2 As RadioButton
    Friend WithEvents rdoFRS2 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdoFIS1 As RadioButton
    Friend WithEvents rdoVIS1 As RadioButton
    Friend WithEvents rdoVRS1 As RadioButton
    Friend WithEvents rdoFRS1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents grpConcurrent As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rdoFIC2 As RadioButton
    Friend WithEvents rdoVIC2 As RadioButton
    Friend WithEvents rdoVRC2 As RadioButton
    Friend WithEvents rdoFRC2 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents rdoFIC1 As RadioButton
    Friend WithEvents rdoVIC1 As RadioButton
    Friend WithEvents rdoVRC1 As RadioButton
    Friend WithEvents rdoFRC1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txbValS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbValCP2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbValCP1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbRefs As TextBox
End Class
