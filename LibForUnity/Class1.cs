using UnityEngine;

public static class ObjectEdges
{
    
    #region SpriteRenderer

    private static float GetObjectWidthRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.size.x;
    }

    private static float GetObjectHeightRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.size.y;
    }

    public static float GetLeftEdgeRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.min.x;
    }

    public static float GetRightEdgeRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.max.x;
    }

    public static float GetTopEdgeRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.max.y;
    }

    public static float GetBottomEdgeRenderer2D(SpriteRenderer renderer)
    {
        return renderer.bounds.min.y;
    }

    #endregion

    #region Camera
    public static float GetCameraHeight(Camera camera)
    {
        return 2 * camera.orthographicSize;
    }

    public static float GetCameraWidth(Camera camera)
    {
        return GetCameraHeight(camera) * camera.aspect;
    }

    public static float GetLeftCameraEdge(Camera camera)
    {
        return camera.transform.position.x - GetCameraWidth(camera) / 2f;
    }

    public static float GetRightCameraEdge(Camera camera)
    {
        return camera.transform.position.x + GetCameraWidth(camera) / 2f;
    }

    public static float GetTopCameraEdge(Camera camera)
    {
        return camera.transform.position.y + GetCameraHeight(camera) / 2f;
    }

    public static float GetBottomCameraEdge(Camera camera)
    {
        return camera.transform.position.y - GetCameraHeight(camera) / 2f;
    }

    #endregion
}
