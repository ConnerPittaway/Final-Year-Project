using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;

public class checkCode3 : MonoBehaviour
{
    public GameObject nextLevel, deathScreen, deathScreen2;
    public Tile tile;
    public Tilemap tilemap;
    public TileBase tileA;
    public TileBase tileB;
    public DragonHealth dragonHealthbar;
    public PlayerHealth playerHealthbar;
    public List<TMP_InputField> inputs;
    public List<TMP_Text> textFields;
    public Sprite[] doorSprites;
    public sceneLoader sceneManager;

    public bool playerDead, dragonDead, running;

    private int originalPlayerAttack, originalPlayerNumAttack, originalDragonAttack, originalDragonNumAttack;
    /* [0] - playerHealth
     * [1] - playerAttack
     * [2] - playerNumberOfAttacks
     * [3] - dragonHealth
     * [4] - dragonAttack
     * [5] - dragonNumberOfAttacks
     */
    // Start is called before the first frame update
    void Start()
    {
        if (Audio.Instance.currentlyPlaying != "Background Music Track 2")
        {
            Audio.Instance.PlayMusic("Background Music Track 2");
        }
        levelManager.Instance.unlockedLevels[2] = true;
        playerDead = false;
        dragonDead = false;
        running = false;
        //Start Tile
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);

        originalPlayerAttack = int.Parse(inputs[1].text);
        originalPlayerNumAttack = int.Parse(inputs[2].text);
        originalDragonAttack = int.Parse(inputs[4].text);
        originalDragonNumAttack = int.Parse(inputs[5].text);

        inputs[1].onEndEdit.AddListener(delegate { playerValuesChanged(); });
        inputs[2].onEndEdit.AddListener(delegate { playerValuesChanged(); });
        inputs[4].onEndEdit.AddListener(delegate { dragonValuesChanged(); });
        inputs[5].onEndEdit.AddListener(delegate { dragonValuesChanged(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDoor()
    {
        //Play Sound
        if (nextLevel.active == false)
        {
            Audio.Instance.PlaySFX("Door Open");
        }
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileB);
        nextLevel.SetActive(true);
    }

    /* [0] - playerHealth
     * [1] - playerAttack
     * [2] - playerNumberOfAttacks
     * [3] - dragonHealth
     * [4] - dragonAttack
     * [5] - dragonNumberOfAttacks
     */
    IEnumerator dragonDamage()
    {
        int playerAttack = int.Parse(inputs[1].text);
        int playerNumberOfAttacks = int.Parse(inputs[2].text);
        int dragonHealth = int.Parse(inputs[3].text);

        for (int i = 0; i < playerNumberOfAttacks; i++)
        {
            Debug.Log("Running");
            if(dragonHealth > 0)
            {
                Audio.Instance.PlaySFX("Damage");
                dragonHealthbar.dragonTakeDamage(playerAttack);
                dragonHealth = (int)dragonHealthbar.health;
                inputs[3].text = dragonHealthbar.health.ToString();
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                dragonDead = true;
                StopCoroutine(dragonDamage());
                running = false;
                break;
            }
        }

        if(dragonHealth <= 0)
        {
            dragonDead = true;
            OpenDoor();
        }
        StopCoroutine(dragonDamage());
        running = false;
        //StartCoroutine(playerDamage());
        //StopCoroutine(dragonDamage());
        //if(!dragonDead)
        // {
        //   StartCoroutine(playerDamage());
        //}
    }

    IEnumerator playerDamage()
    {
        running = true;

        int dragonAttack = int.Parse(inputs[4].text);
        int dragonNumberOfAttacks = int.Parse(inputs[5].text);
        int playerHealth = int.Parse(inputs[0].text);

        Debug.Log(playerHealth);
        for (int i = 0; i < dragonNumberOfAttacks; i++)
        {
            Debug.Log("Running");
            if (playerHealth > 0)
            {
                Audio.Instance.PlaySFX("Damage");
                playerHealthbar.playerTakeDamage(dragonAttack);
                playerHealth = (int)playerHealthbar.health;
                inputs[0].text = playerHealthbar.health.ToString();
            }
            else
            {
                playerDead = true;
                StopCoroutine(playerDamage());
                running = false;
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }

        if(playerHealth > 0)
        {
            StartCoroutine(dragonDamage());
        }
        else
        {
            playerDead = true;
            running = false;
            StopCoroutine(playerDamage());
        }
        //StopCoroutine(playerDamage());
    }

    public void CheckInputs()
    {
        int playerHealth = int.Parse(inputs[0].text);
        int playerAttack = int.Parse(inputs[1].text);
        //int playerNumberOfAttacks = int.Parse(inputs[2].text);
        int dragonHealth = int.Parse(inputs[3].text);
        int dragonAttack = int.Parse(inputs[4].text);
        //int dragonNumberOfAttacks = int.Parse(inputs[5].text);

        if (running)
        {
            Debug.Log("Loop Already Running");
            return;
        }

        if(playerDead)
        {
            Debug.Log("Player Already Dead");
            return;
        }
        else
        {
            if (playerHealth >= playerHealthbar.maxHealth)
            {
                playerHealthbar.maxHealth = playerHealth;
                playerHealthbar.health = playerHealth;
                playerHealthbar.healthBar.SetHealth(playerHealth, playerHealth);
                //playerHealthbar.healthBar.slider.maxValue = playerHealth;
            }
            else
            {
                if (playerHealth <= 0)
                {
                    (playerHealthbar.transform.gameObject).SetActive(false);
                    playerDead = true;
                    Audio.Instance.PlaySFX("Player Death");
                    deathScreen2.SetActive(true);
                    //sceneManager.LoadScene0();
                }
                else
                {
                    playerHealthbar.health = playerHealth;
                    playerHealthbar.healthBar.SetHealth(playerHealth, playerHealthbar.maxHealth);
                }
            }
        }

        if (dragonDead)
        {
            Debug.Log("Dragon Already Dead");
            return;
        }
        else
        {
            if (dragonHealth >= dragonHealthbar.maxHealth)
            {
                dragonHealthbar.maxHealth = dragonHealth;
                dragonHealthbar.health = dragonHealth;
                dragonHealthbar.healthBar.SetHealth(dragonHealth, dragonHealth);
                //dragonHealthbar.healthBar.slider.maxValue = dragonHealth;
            }
            else
            {
                if (dragonHealth <= 0)
                {
                    //Play Sound
                    if (nextLevel.active == false)
                    {
                        Audio.Instance.PlaySFX("Dragon Death");
                        Audio.Instance.PlaySFX("Door Open");
                    }

                    (dragonHealthbar.transform.gameObject).SetActive(false);
                    dragonDead = true;
                    OpenDoor();
                }
                else
                {
                    dragonHealthbar.health = dragonHealth;
                    dragonHealthbar.healthBar.SetHealth(dragonHealth, dragonHealthbar.maxHealth);

                }
            }
        }

        Debug.Log("Player Health " + playerHealth);
        Debug.Log("Player Attack " + playerAttack);
        Debug.Log("Dragon Health " + dragonHealth);
        Debug.Log("Dragon Attack " + dragonAttack);


        if(dragonHealth > 0 && playerHealth > 0)
        {
            StartCoroutine(playerDamage());
            //StartCoroutine(dragonDamage());
        }
        else if(playerHealth <= 0)
        {
            Debug.Log("Player Already Defeated");
        }
        else if(dragonHealth <= 0)
        {
            Debug.Log("Dragon Already Defeated");
        }
    }

    public void playerValuesChanged()
    {
        if (originalPlayerAttack < int.Parse(inputs[1].text))
        {
            Debug.Log("Buffed");
            Achievements.Instance.SetAchievementsLevel3("buffPlayer", true);
        }
        else if(originalPlayerNumAttack < int.Parse(inputs[2].text))
        {
            Debug.Log("Buffed");
            Achievements.Instance.SetAchievementsLevel3("buffPlayer", true);
        }
        else
        {
            Debug.Log("No buff");
            //Achievements.Instance.SetAchievementsLevel2("changeSwordPrice", true);
        }
    }
    public void dragonValuesChanged()
    {
        if (originalDragonAttack > int.Parse(inputs[4].text))
        {
            Debug.Log("Nerfed");
            Achievements.Instance.SetAchievementsLevel3("nerfDragon", true);
        }
        else if (originalDragonNumAttack > int.Parse(inputs[5].text))
        {
            Debug.Log("Nerfed");
            Achievements.Instance.SetAchievementsLevel3("nerfDragon", true);
        }
        else
        {
            Debug.Log("No nerf");
            //Achievements.Instance.SetAchievementsLevel2("changeSwordPrice", true);
        }
    }
}
