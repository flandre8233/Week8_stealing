using System.Collections.Generic;
using UnityEngine;
 
public class DrawSectorSolid : MonoBehaviour
{
    private SectorDetection _sector;//Sector detection script
 
    public static GameObject go;
    public static MeshFilter mf;
    public static MeshRenderer mr;
    public static Shader shader;
 
    private void Awake()
    {
        _sector = GetComponent<SectorDetection>();
    }
 
    void Update()
    {
        DrawSectorArea(transform, transform.localPosition, _sector.Angle, _sector.Distance);
    }
 
    /// <summary>
         /// Create Mesh
    /// </summary>
         /// <param name="vertices">store the list of vertices</param>
    /// <returns></returns>
    private static GameObject CreateMesh(List<Vector3> vertices)
    {
        int[] triangles;
        Mesh mesh = new Mesh();
        int triangleAmount = vertices.Count - 2;
        triangles = new int[3 * triangleAmount];
 
                 //According to the number of triangles, calculate the vertex order of drawing triangles (index)   
                 //The order must be clockwise or counterclockwise      
        for (int i = 0; i < triangleAmount; i++)
        {
                         triangles[3 * i] = 0;//Fix the first point      
            triangles[3 * i + 1] = i + 1;
            triangles[3 * i + 2] = i + 2;
        }
 
        if (go == null)
        {
            go = new GameObject("SectorArea");
                         go.transform.position = new Vector3(0, 0.1f, 0);//Let the drawn graphics rise a bit to prevent being blocked by the ground  
            mf = go.AddComponent<MeshFilter>();
            mr = go.AddComponent<MeshRenderer>();
            shader = Shader.Find("Unlit/Color");
        }
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles;
        mf.mesh = mesh;
        mr.material.shader = shader;
        mr.material.color = Color.red;
        return go;
    }
 
    /// <summary>
         /// Draw a fan-shaped area
    /// </summary>
    /// <param name="t"></param>
    /// <param name="center"></param>
    /// <param name="angle"></param>
    /// <param name="radius"></param>
    public static void DrawSectorArea(Transform t, Vector3 center, float angle, float radius)
    {
                 int pointAmount = 100;//The number of points, the larger the value, the smoother the curve   
        float eachAngle = angle / pointAmount;
        Vector3 forward = t.forward;
        List<Vector3> vertices = new List<Vector3>();
        vertices.Add(center);
        for (int i = 1; i < pointAmount - 1; i++)
        {
            Vector3 pos = Quaternion.Euler(0f, -angle / 2 + eachAngle * (i - 1), 0f) * forward * radius + center;
            vertices.Add(pos);
        }
        CreateMesh(vertices);
    }
}

