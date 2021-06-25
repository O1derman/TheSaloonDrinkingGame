using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticVariables
{
    private static bool spinTheBottleCategory = false;
    private static bool gameWithoutTasks = false;

    public static bool SpinTheBottleCategory { get => spinTheBottleCategory; set => spinTheBottleCategory = value; }
    public static bool GameWithoutTasks { get => gameWithoutTasks; set => gameWithoutTasks = value; }
}
