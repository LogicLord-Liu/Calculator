# HELLO EVERYONE

This article will show you how to design a simple calculator program based on WPF application.

* First step
  > We should create a new project about .NET WPF.
  > Just like this.
  >> ![Picture Teach](https://img-blog.csdnimg.cn/img_convert/4a82ae81b38c5562dd165121ae0350ea.jpeg)
* Then you can see the following interface.
  >![Interface](https://img-blog.csdnimg.cn/20210114131622704.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1N0dXBpZF9raWRvZk9iag==,size_16,color_FFFFFF,t_70)

* Finally you can set property for your WPF project.
  > Just like this:
  >> 1.Right-clicking the button will pop up "Edit Text" and the button will become editable.
  >> 2.Directly modify Content information in XAML.
  >> 3.Code control modification button displays information.
  > In XAML, add the name attribute to the current component. Double-clicking the Button component will automatically generate a button response event. Add the MessageBox pop-up window to the response event and modify the button display.
  ```C#
    <Grid>
        <Button Content="Button" HorizontalAlignment="Left" Margin="353,135,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click"  Name="MyBtn"/>
    </Grid>
  ```
  ```C#
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyBtn.Content = "修改按钮名称";
            MessageBox.Show("HelloWPF 按钮点击");
        }
  ```

* Final step
  > Running and Debug.
  >>![Running Debug](https://img-blog.csdnimg.cn/20210114130256270.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1N0dXBpZF9raWRvZk9iag==,size_16,color_FFFFFF,t_70)

## With just these stimple steps,you can develop s symple calculator projram. Let's do it.
## Thank for your watching.

> Please pay attention：
> If you have some problems about this passage. Please contact me via my email.

> Email: luc444175@gmail.com

> If you still have questions about this tutorial, please refer to [the official Microsoft documentation](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/introduction-to-wpf?view=netframeworkdesktop-4.8&preserve-view=true
) for further information.




                           
