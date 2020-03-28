          int balonYonX;
          int balonYonY;
          private void setBalonDirection()
          {
              balonYonX = rnd.Next(1, 3);
              balonYonY = rnd.Next(1, 3);
          }
          private void setRandomBalonDirection()
          {
              int x;
              x = rnd.Next(1, 3);
              if (balonYonX < 0)
              {
                  x *=-1;
              }

              int y;
              y = rnd.Next(1, 3);
              if (balonYonY < 0)
              {
                  y *= -1;
              }

              balonYonX = x;
              balonYonY = y;
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
                      setRandomBalonDirection();
                  }

              }
              else
              {
                  if (balon.Left + balon.Width >= this.Width)
                  {
                      balonYonX *= -1;
                      setRandomBalonDirection();
                  }
              }

              if (balonYonY <= 0)
              {
                  if (balon.Top <= 0)
                  {
                      balonYonY *= -1;
                      setRandomBalonDirection();
                  }

              }
              else
              {
                  if (balon.Top + balon.Height >= this.Height)
                  {
                      balonYonY *= -1;
                      setRandomBalonDirection();
                  }
              }
          }
