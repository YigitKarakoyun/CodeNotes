//-------------------------------------------------------------------------------
//----------------------- SADECE MOUSE_DOWN DA ----------------------------------
//----------------------- FARENÄ°N DÄ°Ä�ER TIKLAMALARI TESPÄ°T EDÄ°LEBÄ°LÄ°YOR----------
//----------------------- CLICKDE OLMUYOR ---------------------------------------

private void button_MouseDown(object sender, MouseEventArgs e)
{
    Button button = sender as Button;
    if (e.Button == MouseButtons.Left){ MessageBox.Show("Left");}
    if (e.Button == MouseButtons.Middle){ MessageBox.Show("Middle");}
    if (e.Button == MouseButtons.Right){MessageBox.Show("Right");}
}




