using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroObjectDemo
{
    internal class Hero
    {
        //This is a blueprint for a Hero - that's what an object class is


        //attributes go here - attributes define the state of our object
        private int _x, _y;     //hero coordinates
        private int _health;    //hero health
        private float _speed;   //hero speed (if the hero actually moved)
        private string _name;   //hero name
        private string _weapon; //hero current weapon

        //Constructor 1 - sets the default values for the hero attributes
        public Hero()
        {
            _name = "Zag";
            _x = 10;
            _y = 10;
            _speed = 5.0f;
            _weapon = "sword";
            _health = 100;
        }

        //Constructor 2 - this constructor passed in values to have a custom object
        public Hero(string nameIn, int xIn, int yIn, float speedIn, string weaponIn, int healthIn)
        {
            //check the xIn, yIn, and speedIn values and make sure they make sense, change them
            //if they don't make sense
            if (xIn < 0 || xIn > 1280) xIn = 0;
            _x = xIn;

            if (yIn < 0 || yIn > 1024)
                yIn = 0;
            _y = yIn;

            if (speedIn < 0 || speedIn > 100)
                speedIn = 5.0f;
            _speed = speedIn;

            //these variables could use some checks - try for yourself?
            _name = nameIn;
            _weapon = weaponIn;
            _health = healthIn;
        }


        //getter or accessor methods - these methods return the attribute values
        //they are a way to know what values the hero is currently holding.

        //notice they all start with public, then have a "return type" that matches the type
        //of each attribute.
        public string GetName() { return _name; }
        public int GetX() { return _x; }
        public int GetY() { return _y; }
        public int GetHealth() { return _health; }
        public float GetSpeed() { return _speed;}
        public string GetWeapon() { return _weapon; }
        public bool IsDead() { return  _health <= 0; }


        //setters or mutators - these methods "change", or mutate our object. They are 
        //kind of like the costructor, but we call them AFTER the object has been constructed.

        //notice how each one has void as the return type and they DON'T have a return statement 
        //inside. Each of these methods should have some checks to make sure the incoming values make
        //sense.
        public void SetX(int xIn)
        {
            _x = xIn;
        }
        public void SetY(int yIn)
        {
            _y = yIn;
        }
        public void TakeDamage(int damageIn)
        {
            _health -= damageIn;
        }
        public void Heal(int healthIn)
        {
            _health += healthIn;
        }
        public void ChangeWeapon(string weaponIn)
        {
            _weapon = weaponIn;
        }
        public void ChangeSpeed(float speedIn)
        {
            _speed = speedIn;
        }

        //helper methods don't change or read the object attributes, instead they simply help
        //the object to some other job or behaviour.
        public int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(4, 21);
        }



    }
}
