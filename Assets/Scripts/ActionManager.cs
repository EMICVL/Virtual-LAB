using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static bool Bool_0 { get; set; }
    public static bool Bool_1 { get; set; }
    public static bool Bool_2 { get; set; }
    public static bool Bool_3 { get; set; }
    public static bool Bool_4 { get; set; }
    public static bool Bool_5 { get; set; }

    public static bool AllLevelsCompleted
    {
        get
        {
            return Bool_0 &&
                   Bool_1 &&
                   Bool_2 &&
                   Bool_3 &&
                   Bool_4 &&
                   Bool_5;
        }
    }

    public static GUIContent[] contents { get; set; }
    public Texture BoxTexture;
    public Texture BoxTextureCompleted;
    public static ActionManager Instance { get; set; }
    GUIStyle style = new GUIStyle();

    // Use this for initialization
    void Start ()
    {
        Instance = this;
        style.alignment = TextAnchor.MiddleLeft;
        style.fontSize = 15;
        style.normal.textColor = Color.green;

        contents = new GUIContent[7];
        
        var content0 = new GUIContent(@"Bacterial culture(suspension)", BoxTexture,
            "Remove a loopful of bacteria from tube");
        contents[0] = content0;

        var content1 = new GUIContent(@"Glass slide", BoxTexture,
            "Place the loopful of bacteria in the center of the target circle on the slide");
        contents[1] = content1;

        var content2 = new GUIContent(@"Cover the smear", BoxTexture,
            "Cover the smear withcrystal violet solution\n\n    and let stand  for 30-60 seconds.Briefly wash of\n\n        stainwith distilled water and dry the slide");
        contents[2] = content2;

        var content3 = new GUIContent(@"Cover the smear with Lugol’s", BoxTexture,
            "Cover the smear with Lugol’s\n\n        iodinesolution and let it stand \n\n    for 30-60 seconds.Wash of smear\n\n        with distilled water");
        contents[3] = content3;

        var content4 = new GUIContent(@"Flood the smear with", BoxTexture,
            "96% ethyl alcohol for 30 seconds.");
        contents[4] = content4;

        //var content5 = new GUIContent(@"Cover the smear with fuksin", BoxTexture,
        //    "  Cover the smear with fuksin(or safranin) solution for 30     seconds.Pour off fuksinsolution from smear and wash\n\n        gently with distilled water for 2-3 seconds.\n\n        Drythe smear with bibulous paper.");
        //contents[5] = content5;

        var content6 = new GUIContent(@"Put a drop of immersion oil", BoxTexture,
            @" Put a drop of immersion oil on thesmear and examine the smear under immersion objective");
        contents[5] = content6;
    }
    
    public static int BoxWidth = 250;
    public static int BoxHeight = 50;
	public void OnGUI()
    {
        //GUI.Box(new Rect(0, 0, BoxWidth, BoxHeight), "This is a box");
        if (!CustomBehavior.ShowFirstMenu&&!AllLevelsCompleted)
        {
            int h = 0;
            foreach (var content in contents)
            {
                GUI.Box(new Rect(0, h, BoxWidth, BoxHeight), content, style);
                h += BoxHeight;
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
