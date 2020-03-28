frmDilEkle frm;

if (frm!=null)
{
    if (frm.IsDisposed)
    {                    
	frm = new frmDilEkle();          
	frm.FormClosed += FrmDilEkle_FormClosed;        
	frm.Show();
                
    }
                
}
else
{
    frm = new frmDilEkle();
    frm.FormClosed += FrmDilEkle_FormClosed;
    frm.Show();
}        
