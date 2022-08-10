// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class Plane : SceneEntity
{
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 normal;
    
    public Vector3 Center => this.center;
    public Vector3 Normal => this.normal;
    
    public override RaycastHit? Intersect(Ray ray)
    {
        
        return base.Intersect(ray);
    }
}
