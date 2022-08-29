using System;
using System.Drawing;


public class Class1
{
	public Class1()
	{

        Graphics g; //declare a graphics object called g
        enf enf1 = new enf(); //create the object, enf1

          // declare fields to use in the class
    public int x, y, width, height;//variables for the rectangle
    public Image enfImage;//variable for the planet's image

    public Rectangle enfRec;//variable for a rectangle to place our image in
    public int score;
    //Create a constructor (initialises the values of the fields)
    public Planet()
    {
        x = 10;
        y = 10;
        width = 20;
        height = 20;
        //enfImage contains the CorpFighter.png image
        enfImage = Properties.Resources.CorpFighter;
        enfRec = new Rectangle(x, y, width, height);
    }

    // Methods for the Planet class
    public void DrawPlanet(Graphics g)
    {
        g.DrawImage(planetImage, planetRec);
    }




}
}
