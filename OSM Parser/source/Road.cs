/* ========================================================================= *
 * Name        : Open Street Maps Parser
 * Author      : Nuno Filipe Sousa da Silva nufil.silva@gmail.com
 * Version     : 1.0
 * Copyright   : Nuno Filipe Sousa da Silva
 * Description : 
 * ========================================================================= */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMapsParser
{
    class Road
    {
        long id;
        string name;
        bool twoWay;
        public Road(long id, string name, bool twoWay)
        {
            this.id=id;
            this.name = name;
            this.twoWay = twoWay;
        }

        public long getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public bool isTwoWay()
        {
            return twoWay;
        }
    }
}
