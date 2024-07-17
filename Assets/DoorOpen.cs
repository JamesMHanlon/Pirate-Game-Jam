using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public int hoverSortingOrder = -1; // Sorting order when hovered
    private int originalSortingOrder;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSortingOrder = spriteRenderer.sortingOrder;
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePosition.x, mousePosition.y);
        
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            spriteRenderer.sortingOrder = hoverSortingOrder;
        }
        else
        {
            spriteRenderer.sortingOrder = originalSortingOrder;
        }
    }
}
