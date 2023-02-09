using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
[Header("Formula")]

   [SerializeField]GameObject algebra;
   [SerializeField]GameObject trigonometry;
   [SerializeField]GameObject calculus;
   [SerializeField]GameObject algebraSprite;
   [SerializeField]GameObject trigonometrySprite;
   [SerializeField]GameObject calculusSprite;

[Header("Books")]

   [SerializeField]GameObject algebraButton;
   [SerializeField]GameObject trigoButton;
   [SerializeField]GameObject calculusButton;
   
[Header("Misc")]

   [SerializeField]GameObject Transition;
   [SerializeField]GameObject close;

   public SpriteRenderer libraryBG;
   public List<Sprite> bgOptions = new List<Sprite>();
   void Awake() 
{
    Transition.SetActive(true);
}
   public void Algebra()
   {
    algebra.SetActive(true);
    trigonometry.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(true);
    algebraButton.SetActive(false);
    trigoButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[1];
   }
   public void Trigonometry()
   {
    algebra.SetActive(false);
    trigonometry.SetActive(true);
    calculus.SetActive(false);
    close.SetActive(true);
    algebraButton.SetActive(false);
    trigoButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[2];
   }
   public void Calculus()
   {
    algebra.SetActive(false);
    trigonometry.SetActive(false);
    calculus.SetActive(true);
    close.SetActive(true);
    algebraButton.SetActive(false);
    trigoButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[3];
   }

   public void CloseBook()
   {
    algebra.SetActive(false);
    trigonometry.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(false);
    algebraButton.SetActive(true);
    trigoButton.SetActive(true);
    calculusButton.SetActive(true);
    libraryBG.sprite = bgOptions[0];
   }
}
