using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlantFactory
{
    IPlant Create(PlantRequirements requirements);
}

public class FullSunFactory : IPlantFactory
{
    public IPlant Create(PlantRequirements requirements)
    {
        if(requirements.Flower)
        {
            if(requirements.Thorns)
            {
                return new Cactus();
            }
            else
            {
                return new Sunflower();
            }
        }
        else
        {
            if(requirements.Thorns)
            {
                return new Agarita();
            }
            else
            {
                return new Lambsear();
            }
        }
    }
}

public class PartSunFactory : IPlantFactory
{
    public IPlant Create(PlantRequirements requirements)
    {
        if (requirements.Flower)
        {
            if (requirements.Thorns)
            {
                return new Firethorn();
            }
            else
            {
                return new Viola();
            }
        }
        else
        {
            if (requirements.Thorns)
            {
                return new Holly();
            }
            else
            {
                return new Carrots();
            }
        }
    }
}

public class FullShadeFactory : IPlantFactory
{
    public IPlant Create(PlantRequirements requirements)
    {
        if (requirements.Flower)
        {
            if (requirements.Thorns)
            {
                return new Rhododendron();
            }
            else
            {
                return new Fuchsia();
            }
        }
        else
        {
            if (requirements.Thorns)
            {
                return new Barberry();
            }
            else
            {
                return new InkBerry();
            }
        }
    }
}

public abstract class AbstractPlantFactory
{
    public abstract IPlant Create();
}

public class PlantFactory : AbstractPlantFactory
{
    private readonly IPlantFactory _factory;
    private readonly PlantRequirements _requirements;

    public PlantFactory(PlantRequirements requirements)
    {
        if(requirements.HoursOfSun >= 6)
        {
            _factory = new FullSunFactory();
        }
        else if(requirements.HoursOfSun <6 && requirements.HoursOfSun >= 3)
        {
            _factory = new PartSunFactory();
        }
        else
        {
            _factory = new FullShadeFactory();
        }
        _requirements = requirements;
    }

    public override IPlant Create()
    {
        return _factory.Create(_requirements);
    }
}