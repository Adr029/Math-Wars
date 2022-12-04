using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
   [SerializeField]GameObject arithmetic;
   [SerializeField]GameObject algebra;
   [SerializeField]GameObject calculus;
   [SerializeField]GameObject close;
   [SerializeField]GameObject arithmeticButton;
   [SerializeField]GameObject algebraButton;
   [SerializeField]GameObject calculusButton;
   public SpriteRenderer libraryBG;
   public List<Sprite> bgOptions = new List<Sprite>();

   public void Arithmetic()
   {
    arithmetic.SetActive(true);
    algebra.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[1];
   }
   public void Algebra()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(true);
    calculus.SetActive(false);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[2];
   }
   public void Calculus()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(true);
    close.SetActive(true);
    arithmeticButton.SetActive(false);
    algebraButton.SetActive(false);
    calculusButton.SetActive(false);
    libraryBG.sprite = bgOptions[3];
   }

   public void CloseBook()
   {
    arithmetic.SetActive(false);
    algebra.SetActive(false);
    calculus.SetActive(false);
    close.SetActive(false);
    arithmeticButton.SetActive(true);
    algebraButton.SetActive(true);
    calculusButton.SetActive(true);
    libraryBG.sprite = bgOptions[0];
   }
}
