using FishNet.Component.Animating;
using FishNet.Object;
using ReadyPlayerMe.Core;
using ReadyPlayerMe.Core.WebView;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationStateConroller : MonoBehaviour
{
    Animator animator;
    NetworkAnimator networkAnimator;
    Mesh mesh;
    SkinnedMeshRenderer skinnedMeshRenderer;
    int isclappingHash;
    int isinsultingHash;
    int iskissingHash;
    int issalutingHash;
    int isshakinghandsHash;
    int isheadingnoHash;
    int isdancingHash;
    int isproudHash;
    int isprayingHash;
    int issadHash;
    int islaughingHash;
    int isangryHash;
    int isvicoryHash;
    int isheadnoddingHash;
    int isreactingHash;
    int ishappyHash;
    int istalkingHash;
    int isblushHash;
    int isthumbdownHash;
    int isthumbUpHash;
    int iscringeHash;
    int isinterHash;
    int isthankHash;



    void Start()
    {
        animator = GetComponent<Animator>();
        networkAnimator = transform.parent.GetComponent<NetworkAnimator>();
        networkAnimator.SetAnimator(animator);
        skinnedMeshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        mesh = skinnedMeshRenderer.sharedMesh;
        isclappingHash = Animator.StringToHash("isclapping");
        isinsultingHash = Animator.StringToHash("isinsulting");
        iskissingHash = Animator.StringToHash("iskissing");
        issalutingHash = Animator.StringToHash("issaluting");
        isshakinghandsHash = Animator.StringToHash("isshakinghands");
        isheadingnoHash = Animator.StringToHash("isheadingno");
        isdancingHash = Animator.StringToHash("isdancing");
        isproudHash = Animator.StringToHash("isproud");
        isprayingHash = Animator.StringToHash("ispraying");
        issadHash = Animator.StringToHash("issad");
        islaughingHash = Animator.StringToHash("islaughing");
        isangryHash = Animator.StringToHash("isangry");
        isvicoryHash = Animator.StringToHash("isvictory");
        isheadnoddingHash = Animator.StringToHash("isheadnodding");
        isreactingHash = Animator.StringToHash("isreacting");
        ishappyHash = Animator.StringToHash("ishappy");
        istalkingHash = Animator.StringToHash("istalking");
        isblushHash = Animator.StringToHash("isblushing");
        isthumbdownHash = Animator.StringToHash("isthumbdown");
        isthumbUpHash = Animator.StringToHash("isthumbup");
        iscringeHash = Animator.StringToHash("iscringe");
        isthankHash = Animator.StringToHash("isthank");
        isinterHash = Animator.StringToHash("isinter");

        




    }

    










    // Update is called once per frame
    void Update()
    {

   






        getClappingAnimation("value");
        getInsultingAnimation("value");
        getKissingAnimation("value");
        getSalutingAnimation("value");
        getShakinghandsAnimation("value");
        getheadingnoAnimation("value");
        getDancingAnimation("value");
        getProudAnimation("value");
        getPrayingAnimation("value");
        getSadAnimation("value");
        getLaughingAnimation("value");
        getAngryAnimation("value");
        getVictoryAnimation("value");
        getHeadnoddingAnimation("value");
        getReactingAnimation("value");
        getHappyAnimation("value");
        getTalkingAnimation("value");
        getBlushingAnimation("value");
        getThumbdownAnimation("value");
        getThumbUPAnimation("value");
        getCringeAnimation("value");
        getThankAnimation("value");
        getInterAnimation("value");


     

      










    }

   



    void getduplaugh(string fake)
    {

        animator.SetBool(islaughingHash, false);
        StartCoroutine(Example());

    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(islaughingHash, true);
    }



    void getdupinsult(string fake)
    {

        animator.SetBool(isinsultingHash, false);
        StartCoroutine(Example2());

    }

    IEnumerator Example2()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isinsultingHash, true);
    }



    void getdupkiss(string fake)
    {

        animator.SetBool(iskissingHash, false);
        StartCoroutine(Example3());

    }

    IEnumerator Example3()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(iskissingHash, true);
    }



    void getdupheadno(string fake)
    {

        animator.SetBool(isheadingnoHash, false);
        StartCoroutine(Example4());

    }

    IEnumerator Example4()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isheadingnoHash, true);
    }



    void getdupheadnodding(string fake)
    {

        animator.SetBool(isheadnoddingHash, false);
        StartCoroutine(Example5());

    }

    IEnumerator Example5()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isheadnoddingHash, true);
    }





    void getdupdance(string fake)
    {

        animator.SetBool(isdancingHash, false);
        StartCoroutine(Example6());

    }

    IEnumerator Example6()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isdancingHash, true);
    }




    void getduppray(string fake)
    {

        animator.SetBool(isprayingHash, false);
        StartCoroutine(Example7());

    }

    IEnumerator Example7()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isprayingHash, true);
    }


    void getdupproud(string fake)
    {

        animator.SetBool(isproudHash, false);
        StartCoroutine(Example8());

    }

    IEnumerator Example8()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isproudHash, true);
    }


    void getduphappy(string fake)
    {

        animator.SetBool(ishappyHash, false);
        StartCoroutine(Example9());

    }

    IEnumerator Example9()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(ishappyHash, true);
    }


    void getdupsalute(string fake)
    {

        animator.SetBool(issalutingHash, false);
        StartCoroutine(Example10());

    }

    IEnumerator Example10()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(issalutingHash, true);
    }


    void getdupsad(string fake)
    {

        animator.SetBool(issadHash, false);
        StartCoroutine(Example11());

    }

    IEnumerator Example11()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(issadHash, true);
    }



    void getdupangry(string fake)
    {

        animator.SetBool(isangryHash, false);
        StartCoroutine(Example12());

    }

    IEnumerator Example12()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isangryHash, true);
    }



    void getdupthumbup(string fake)
    {

        animator.SetBool(isthumbUpHash, false);
        StartCoroutine(Example13());

    }

    IEnumerator Example13()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isthumbUpHash, true);
    }


    void getdupthumbdown(string fake)
    {

        animator.SetBool(isthumbdownHash, false);
        StartCoroutine(Example14());

    }

    IEnumerator Example14()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isthumbdownHash, true);
    }


    void getdupclap(string fake)
    {

        animator.SetBool(isclappingHash, false);
        StartCoroutine(Example15());

    }

    IEnumerator Example15()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isclappingHash, true);
    }



    void getdupthank(string fake)
    {

        animator.SetBool(isthankHash, false);
        StartCoroutine(Example16());

    }

    IEnumerator Example16()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isthankHash, true);
    }




    void getdupinter(string fake)
    {

        animator.SetBool(isinterHash, false);
        StartCoroutine(Example17());

    }

    IEnumerator Example17()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isinterHash, true);
    }





    void getduptalk(string fake)
    {

        animator.SetBool(istalkingHash, false);
        StartCoroutine(Example18());

    }

    IEnumerator Example18()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(istalkingHash, true);
       
    }


    void getdupshakehand(string fake)
    {

        animator.SetBool(isshakinghandsHash, false);
        StartCoroutine(Example19());

    }

    IEnumerator Example19()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isshakinghandsHash, true);
    }



    void getdupcringe(string fake)
    {

        animator.SetBool(iscringeHash, false);
        StartCoroutine(Example20());

    }

    IEnumerator Example20()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(iscringeHash, true);
    }




    void getdupblush(string fake)
    {

        animator.SetBool(isblushHash, false);
        StartCoroutine(Example21());

    }

    IEnumerator Example21()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isblushHash, true);
    }




    void getdupreact(string fake)
    {

        animator.SetBool(isreactingHash, false);
        StartCoroutine(Example22());

    }

    IEnumerator Example22()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isreactingHash, true);
    }



    void getdupvictory(string fake)
    {

        animator.SetBool(isvicoryHash, false);
        StartCoroutine(Example23());

    }

    IEnumerator Example23()
    {
        yield return new WaitForSecondsRealtime(1);
        animator.SetBool(isvicoryHash, true);
    }


















    private void getInterAnimation(string value)
    {
        bool isinter = animator.GetBool(isinterHash);

        if (!isinter && value == "true")
        {
            animator.SetBool(isinterHash, true);



        }

        if (isinter && value == "false")
        {
            animator.SetBool(isinterHash, false);

        }
    }

    private void getThankAnimation(string value)
    {
        bool isthank = animator.GetBool(isthankHash);

        if (!isthank && value == "true")
        {
            animator.SetBool(isthankHash, true);



        }

        if (isthank && value == "false")
        {
            animator.SetBool(isthankHash, false);

        }
    }

    private void getCringeAnimation(string value)
    {
        bool iscringe = animator.GetBool(iscringeHash);

        if (!iscringe && value == "true")
        {
            animator.SetBool(iscringeHash, true);



        }

        if (iscringe && value == "false")
        {
            animator.SetBool(iscringeHash, false);

        }
    }

    private void getThumbUPAnimation(string value)
    {
        bool isthumbup = animator.GetBool(isthumbUpHash);

        if (!isthumbup && value == "true")
        {
            animator.SetBool(isthumbUpHash, true);



        }

        if (isthumbup && value == "false")
        {
            animator.SetBool(isthumbUpHash, false);

            }
    }

    private void getThumbdownAnimation(string value)
    {
        bool isthumbdown = animator.GetBool(isthumbdownHash);

        if (!isthumbdown && value == "true")
        {
            animator.SetBool(isthumbdownHash, true);
           


        }

        if (isthumbdown && value == "false")
        {
            animator.SetBool(isthumbdownHash, false);
           





        }
    }

    private void getBlushingAnimation(string value)
    {
        bool isblushing = animator.GetBool(isblushHash);

        if (!isblushing && value == "true")
        {
            animator.SetBool(isblushHash, true);
        }

        if (isblushing && value == "false")
        {
            animator.SetBool(isblushHash, false);
        }





    }

    private void getTalkingAnimation(string value)
    {
        bool istalking = animator.GetBool(istalkingHash);

        if (!istalking && value == "true")
        {
            animator.SetBool(istalkingHash, true);
          


        }

        if (istalking && value == "false")
        {
            animator.SetBool(istalkingHash, false);
          

         



        }
    }

    private void getHappyAnimation(string value)
    {
        bool ishappy = animator.GetBool(ishappyHash);

        if (!ishappy && value == "true")
        {
           
            animator.SetBool(ishappyHash, true);
           
        }

        if (ishappy && value == "false")
        {
            animator.SetBool(ishappyHash, false);
           
        }


      




    }

    private void getReactingAnimation(string value)
    {
        bool isReacting = animator.GetBool(isreactingHash);

        if (!isReacting && value == "true")
        {
            animator.SetBool(isreactingHash, true);
        }

        if (isReacting && value == "false")
        {
            animator.SetBool(isreactingHash, false);
        }
    }

    private void getHeadnoddingAnimation(string value)
    {
        bool isheadnodding = animator.GetBool(isheadnoddingHash);

     if (!isheadnodding && value == "true")
        {
            animator.SetBool(isheadnoddingHash, true);
        }

        if (isheadnodding && value == "false")
        {
            animator.SetBool(isheadnoddingHash, false);
        }





    }

    private void getVictoryAnimation(string value)
    {
        bool isvictory = animator.GetBool(isvicoryHash);




        if (!isvictory && value == "true")
        {
            animator.SetBool(isvicoryHash, true);
        }

        if (isvictory && value == "false")
        {
            animator.SetBool(isvicoryHash, false);
        }
    }

    private void getAngryAnimation(string value)
    {
        bool isangry = animator.GetBool(isangryHash);

    if (!isangry && value == "true")
        {
            animator.SetBool(isangryHash, true);
        }

        if (isangry && value == "false")
        {
            animator.SetBool(isangryHash, false);
        }
    }

    private void getLaughingAnimation(string value)
    {
        bool islaughing = animator.GetBool(islaughingHash);




        if (!islaughing && value == "true")
        {
            animator.SetBool(islaughingHash, true);
        }

        if (islaughing && value == "false")
        {
            animator.SetBool(islaughingHash, false);
        }

       
        


       
       



    }

   




    private void getSadAnimation(string value)
    {
        bool issad = animator.GetBool(issadHash);

        if (!issad && value == "true")
        {
            animator.SetBool(issadHash, true);
        }

        if (issad && value == "false")
        {
            animator.SetBool(issadHash, false);
        }


    }

    private void getPrayingAnimation(string value)
    {
        bool ispraying = animator.GetBool(isprayingHash);




        if (!ispraying && value == "true")
        {
            animator.SetBool(isprayingHash, true);
        }

        if (ispraying && value == "false")
        {
            animator.SetBool(isprayingHash, false);
        }
    }

    private void getProudAnimation(string value)
    {
        bool iscrying = animator.GetBool(isproudHash);




        if (!iscrying && value == "true")
        {
            animator.SetBool(isproudHash, true);
        }

        if (iscrying && value == "false")
        {
            animator.SetBool(isproudHash, false);
        }
    }

    private void getDancingAnimation(string value)
    {
        bool isdancing = animator.GetBool(isdancingHash);




        if (!isdancing && value == "true")
        {
            animator.SetBool(isdancingHash, true);
        }

        if (isdancing && value == "false")
        {
            animator.SetBool(isdancingHash, false);
        }
    }

    private void getheadingnoAnimation(string value)
    {
        bool isheadingno = animator.GetBool(isheadingnoHash);




        if (!isheadingno && value == "true")
        {
            animator.SetBool(isheadingnoHash, true);
        }

        if (isheadingno && value == "false")
        {
            animator.SetBool(isheadingnoHash, false);
        }
    }

    private void getShakinghandsAnimation(string value)
    {
        bool isshakinghands = animator.GetBool(isshakinghandsHash);




        if (!isshakinghands && value == "true")
        {
            animator.SetBool(isshakinghandsHash, true);
        }

        if (isshakinghands && value == "false")
        {
            animator.SetBool(isshakinghandsHash, false);
        }
    }

    private void getSalutingAnimation(string value)
    {
        bool issaluting = animator.GetBool(issalutingHash);




        if (!issaluting && value == "true")
        {
            animator.SetBool(issalutingHash, true);
        }

        if (issaluting && value == "false")
        {
            animator.SetBool(issalutingHash, false);
        }
    }

    void getKissingAnimation(string value)
    {
        bool iskissing = animator.GetBool(iskissingHash);
      

       

       if (!iskissing && value == "true")
        {
         animator.SetBool(iskissingHash, true);
        }

        if (iskissing && value == "false")
        {
            animator.SetBool(iskissingHash, false);
        }





    }

    void getInsultingAnimation(string value)
    {

       
        bool isinsulting = animator.GetBool(isinsultingHash);
   




        if (!isinsulting && value == "true")
        {
           
           animator.SetBool(isinsultingHash, true);
          
        }

       

        if (isinsulting && value == "false")
        {
            animator.SetBool(isinsultingHash, false);
           
        }





    }

   void getClappingAnimation(string value)
    {


bool isclapping = animator.GetBool(isclappingHash);

      
    if (!isclapping && value == "true")
        {
        animator.SetBool(isclappingHash, true);
        }

       if (isclapping && value == "false")
        {
            animator.SetBool(isclappingHash, false);
        }


    }
















}
