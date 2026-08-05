using UnityEngine;
using UnityEngine.UI;

public class DanceFloorGenerator : MonoBehaviour
{
    public GameObject tilePrefab; // Sem v Inspectoru přetáhneš svůj prefab čtverečku

    void Start()
    {
        // 1. Získáme komponentu Grid Layout Group (OPRAVENO z Grid na GridLayoutGroup)
        GridLayoutGroup someGrid = GetComponent<GridLayoutGroup>();
        if (someGrid == null) return;

        // 2. Zjistíme aktuální šířku a výšku obrazovky (Canvasu)
        RectTransform rectTransform = GetComponent<RectTransform>();
        float canvasWidth = rectTransform.rect.width;
        float canvasHeight = rectTransform.rect.height;

        // 3. Spočítáme, kolik se jich vejde vedle sebe a pod sebe včetně mezer
        float cellW = someGrid.cellSize.x + someGrid.spacing.x;
        float cellH = someGrid.cellSize.y + someGrid.spacing.y;

        int columns = Mathf.CeilToInt(canvasWidth / cellW) + 1;
        int rows = Mathf.CeilToInt(canvasHeight / cellH) + 1;

        int totalTilesNeeded = columns * rows;

        // 4. Vygenerujeme přesný počet čtverečků pro tento monitor!
        for (int i = 0; i < totalTilesNeeded; i++)
        {
            Instantiate(tilePrefab, transform);
        }
    }
}