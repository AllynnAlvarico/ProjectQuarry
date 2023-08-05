Public Class animation
    Public frame_index As Integer
    Public pickaxe_time_interval As Integer
    'this constructor makes it easier for me to adjust the setting of interval or other sets
    Public Sub New()
        frame_index = 0
        pickaxe_time_interval = 150
    End Sub
    'this method makes the animation of the pickaxe
    '(pickaxe) as an imagelist
    '(pickaxe_img) as a picture box
    '(time) as a timer
    Public Sub pickaxe_frame_animation(pickaxe_imglist As ImageList, pickaxe_img As PictureBox, time As Timer)
        'this if section is to determine if there is images on the imagelist
        If pickaxe_imglist.Images.Count = 0 Then
            Return
        End If

        pickaxe_img.Image = pickaxe_imglist.Images(frame_index)
        'this is the setting of interval of the pickaxe frame per second and making it easier
        'to change the value of the interval if needed to.
        time.Interval = pickaxe_time_interval
        time.Start()
        'this "addhandler" adds an event that takes every tick of the timer, a picture on the imagelist
        'will show on the picture box.
        AddHandler time.Tick,
            Sub(sender As Object, e As EventArgs)
                frame_index += 1
                'this section makes the (frame_index) to 0 to loop or repeat the images on the imagelist
                'the process is the (frame_index) value is 0 then as the "tick" goes
                '(frame_index) adds a value of 1 to itself
                'the if section "if (frame_index) is more than the number of the picture on the imagelist
                'then (frame_index) values gets to 0
                If frame_index >= pickaxe_imglist.Images.Count Then
                    frame_index = 0
                End If
                pickaxe_img.Image = pickaxe_imglist.Images(frame_index)
            End Sub
    End Sub
End Class
