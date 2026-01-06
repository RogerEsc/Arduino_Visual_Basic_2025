<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tmrLever1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLever2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSujeto = New System.Windows.Forms.Label()
        Me.lblSesion = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblCOM = New System.Windows.Forms.Label()
        Me.lblL2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblL1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResponses1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResponses2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReinforcers1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblReinforcers2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRfR1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRfR2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrLever1
        '
        '
        'tmrLever2
        '
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSujeto.Location = New System.Drawing.Point(11, 20)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(61, 18)
        Me.lblSujeto.TabIndex = 6
        Me.lblSujeto.Text = "Subject:"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSesion.Location = New System.Drawing.Point(11, 60)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(66, 18)
        Me.lblSesion.TabIndex = 7
        Me.lblSesion.Text = "Session:"
        '
        'lblSubject
        '
        Me.lblSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(98, 20)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(54, 20)
        Me.lblSubject.TabIndex = 8
        Me.lblSubject.Text = "0"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSession
        '
        Me.lblSession.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(98, 60)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(54, 20)
        Me.lblSession.TabIndex = 9
        Me.lblSession.Text = "0"
        Me.lblSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(11, 99)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(40, 18)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "Port:"
        '
        'lblCOM
        '
        Me.lblCOM.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOM.Location = New System.Drawing.Point(88, 99)
        Me.lblCOM.Name = "lblCOM"
        Me.lblCOM.Size = New System.Drawing.Size(64, 20)
        Me.lblCOM.TabIndex = 11
        Me.lblCOM.Text = "0"
        Me.lblCOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblL2
        '
        Me.lblL2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL2.Location = New System.Drawing.Point(530, 39)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(55, 20)
        Me.lblL2.TabIndex = 15
        Me.lblL2.Text = "EXT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lever 2:"
        '
        'lblL1
        '
        Me.lblL1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL1.Location = New System.Drawing.Point(317, 39)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(55, 20)
        Me.lblL1.TabIndex = 13
        Me.lblL1.Text = "EXT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lever 1:"
        '
        'lblResponses1
        '
        Me.lblResponses1.BackColor = System.Drawing.SystemColors.Info
        Me.lblResponses1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResponses1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses1.Location = New System.Drawing.Point(340, 79)
        Me.lblResponses1.Name = "lblResponses1"
        Me.lblResponses1.Size = New System.Drawing.Size(43, 20)
        Me.lblResponses1.TabIndex = 17
        Me.lblResponses1.Text = "0"
        Me.lblResponses1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Responses:"
        '
        'lblResponses2
        '
        Me.lblResponses2.BackColor = System.Drawing.SystemColors.Info
        Me.lblResponses2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResponses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses2.Location = New System.Drawing.Point(553, 79)
        Me.lblResponses2.Name = "lblResponses2"
        Me.lblResponses2.Size = New System.Drawing.Size(43, 20)
        Me.lblResponses2.TabIndex = 19
        Me.lblResponses2.Text = "0"
        Me.lblResponses2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Responses:"
        '
        'lblReinforcers1
        '
        Me.lblReinforcers1.BackColor = System.Drawing.SystemColors.Info
        Me.lblReinforcers1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblReinforcers1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers1.Location = New System.Drawing.Point(340, 118)
        Me.lblReinforcers1.Name = "lblReinforcers1"
        Me.lblReinforcers1.Size = New System.Drawing.Size(43, 20)
        Me.lblReinforcers1.TabIndex = 21
        Me.lblReinforcers1.Text = "0"
        Me.lblReinforcers1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Reinforcers:"
        '
        'lblReinforcers2
        '
        Me.lblReinforcers2.BackColor = System.Drawing.SystemColors.Info
        Me.lblReinforcers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblReinforcers2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers2.Location = New System.Drawing.Point(553, 118)
        Me.lblReinforcers2.Name = "lblReinforcers2"
        Me.lblReinforcers2.Size = New System.Drawing.Size(43, 20)
        Me.lblReinforcers2.TabIndex = 23
        Me.lblReinforcers2.Text = "0"
        Me.lblReinforcers2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Reinforcers:"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Pink
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(88, 139)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 20)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "0"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Time:"
        '
        'lblRfR1
        '
        Me.lblRfR1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRfR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRfR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR1.Location = New System.Drawing.Point(340, 158)
        Me.lblRfR1.Name = "lblRfR1"
        Me.lblRfR1.Size = New System.Drawing.Size(43, 20)
        Me.lblRfR1.TabIndex = 27
        Me.lblRfR1.Text = "0"
        Me.lblRfR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(212, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Rf Ready:"
        '
        'lblRfR2
        '
        Me.lblRfR2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRfR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRfR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR2.Location = New System.Drawing.Point(553, 158)
        Me.lblRfR2.Name = "lblRfR2"
        Me.lblRfR2.Size = New System.Drawing.Size(43, 20)
        Me.lblRfR2.TabIndex = 29
        Me.lblRfR2.Text = "0"
        Me.lblRfR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(424, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 20)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Rf Ready:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(650, 139)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 68)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 234)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRfR2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblRfR1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblReinforcers2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblReinforcers1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblResponses2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblResponses1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblL2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblL1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCOM)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lblSesion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Arduino_VB Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrLever1 As Timer
    Friend WithEvents tmrLever2 As Timer
    Friend WithEvents lblSujeto As Label
    Friend WithEvents lblSesion As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblSession As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lblCOM As Label
    Friend WithEvents lblL2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblL1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResponses1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResponses2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblReinforcers1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblReinforcers2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRfR1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRfR2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
End Class
