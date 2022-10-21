using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlant { }
public class Agarita : IPlant { }       //>6 hours/no/yes
public class Cactus : IPlant { }        //>6 hours/yes/yes
public class Lambsear : IPlant { }      //>6 hours/no/no
public class Sunflower : IPlant { }     //>6 hours/yes/no
public class Holly : IPlant { }         //<6>3 hours/no/yes
public class Firethorn : IPlant { }     //<6>3 hours/yes/yes
public class Carrots : IPlant { }       //<6>3 hours/no/no
public class Viola : IPlant { }         //<6>3 hours/yes/no
public class Barberry : IPlant { }      //<3 hours/no/yes
public class Rhododendron : IPlant { }  //<3 hours/yes/yes
public class InkBerry : IPlant { }      //<3 hours/no/no
public class Fuchsia : IPlant { }       //<3 hours/yes/no