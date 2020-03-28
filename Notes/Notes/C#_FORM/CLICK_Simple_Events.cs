//------------------------ UYGULAMAYI KUCULTUYOR---------------------------------- 
private void buttonMinimize_Click(object sender, EventArgs e)
{
     WindowState = FormWindowState.Minimized;
}

//------------------------ UYGULAMA YENIDEN BASLATIR----------------------------
private void buttonRefresh_Click(object sender, EventArgs e)
{
    Application.Restart();
}

//------------------------ UYGULAMAYI KAPATIR------------------------------------
private void buttonClose_Click(object sender, EventArgs e)
{
      Application.Exit();
}


