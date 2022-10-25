using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbstractFactory<T>
{
    public T GetNewInstance();
}
