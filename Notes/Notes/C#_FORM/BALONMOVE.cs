          int balonYonX;
          int balonYonY;
          private void setBalonDirection()
          {
              balonYonX = rnd.Next(1, 3);
              balonYonY = rnd.Next(1, 3);
          }

          private void timerBalloon_Tick(object sender, EventArgs e)
          {
              balon.Left += balonYonX;
              balon.Top += balonYonY;

              if (balonYonX <= 0)
              {
                  if (balon.Left <= 0)
                  {
                      balonYonX *= -1;
                      
                  }

              }
              else
              {
                  if (balon.Left + balon.Width >= this.Width)
                  {
                      balonYonX *= -1;
                      
                  }
              }

              if (balonYonY <= 0)
              {
                  if (balon.Top <= 0)
                  {
                      balonYonY *= -1;
                      
                  }

              }
              else
              {
                  if (balon.Top + balon.Height >= this.Height)
                  {
                      balonYonY *= -1;
                      
                  }
              }
          }
