//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


namespace Valve.VR.InteractionSystem.Sample
{
    public class TargetHitEffect : MonoBehaviour
    {
        public Text TextObject;

        public Collider targetCollider;
        public Collider targetCollider2;
        public Collider targetCollider3;
        public Collider targetCollider4;
        public Collider targetCollider5;
        public Collider targetCollider6;

        public GameObject spawnObjectOnCollision;

        public bool colorSpawnedObject = true;

        public bool destroyOnTargetCollision = true;

        private void OnCollisionEnter(Collision collision)
        {

                ContactPoint contact = collision.contacts[0];
                RaycastHit hit;

                float backTrackLength = 1f;
                Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);
                if (collision.collider.Raycast(ray, out hit, 2))
                {
                    if (colorSpawnedObject)
                    {
                        Renderer renderer = collision.gameObject.GetComponent<Renderer>();
                        Texture2D tex = (Texture2D)renderer.material.mainTexture;
                        Color color = tex.GetPixelBilinear(hit.textureCoord.x, hit.textureCoord.y);

                        if (color.r > 0.7f && color.g > 0.7f && color.b < 0.7f)
                        {
                          
                            if(collision.collider == targetCollider2)
                            {
                                TextObject.text = "WOAH!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }
                            else if(collision.collider == targetCollider3)
                            {
                                TextObject.text = "INSANE!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider4)
                            {
                                TextObject.text = "CRAZY!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider5)
                            {
                                TextObject.text = "MADMAN!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider6)
                            {
                                TextObject.text = "KILLIN IT!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }
                            else
                            {
                                TextObject.text = "COOL!";
                                color = Color.yellow;
                                TextObject.color = color;
                            }

                        }
                        else if (Mathf.Max(color.r, color.g, color.b) == color.r)
                        {
                            if (collision.collider == targetCollider2)
                            {
                                TextObject.text = "POOR!";
                                color = Color.red;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider3)
                            {
                                TextObject.text = "EH NOT BAD!";
                                color = Color.red;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider4)
                            {
                                TextObject.text = "COULD BE BETTER!";
                                color = Color.red;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider5)
                            {
                                TextObject.text = "TRY AGAIN!";
                                color = Color.red;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider6)
                            {
                                TextObject.text = "HMMM!";
                                color = Color.red;
                                TextObject.color = color;
                            }
                            else
                            {
                                TextObject.text = "YUCK!";
                                color = Color.red;
                                TextObject.color = color;
                            }

                        }
                        else if (Mathf.Max(color.r, color.g, color.b) == color.g)
                        {
                            if (collision.collider == targetCollider2)
                            {
                                TextObject.text = "YOU DID IT!";
                                color = Color.green;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider3)
                            {
                                TextObject.text = "A TRUE HERO!!";
                                color = Color.green;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider4)
                            {
                                TextObject.text = "HOLY BUCKETS!";
                                color = Color.green;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider5)
                            {
                                TextObject.text = "WOO HOO!";
                                color = Color.green;
                                TextObject.color = color;
                            }
                            else if (collision.collider == targetCollider6)
                            {
                                TextObject.text = "GOT EM!";
                                color = Color.green;
                                TextObject.color = color;
                            }
                            else
                            {
                                TextObject.text = "WINNER!";
                                color = Color.green;
                                TextObject.color = color;
                            }

                        }
                        else
                            color = Color.yellow;

                        color *= 15f;

                        GameObject spawned = GameObject.Instantiate(spawnObjectOnCollision);
                        spawned.transform.position = contact.point;
                        spawned.transform.forward = ray.direction;

                        Renderer[] spawnedRenderers = spawned.GetComponentsInChildren<Renderer>();
                        for (int rendererIndex = 0; rendererIndex < spawnedRenderers.Length; rendererIndex++)
                        {
                            Renderer spawnedRenderer = spawnedRenderers[rendererIndex];
                            spawnedRenderer.material.color = color;
                            if (spawnedRenderer.material.HasProperty("_EmissionColor"))
                            {
                                spawnedRenderer.material.SetColor("_EmissionColor", color);
                            }
                        }
                    }
                }
                Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 5, true);

                if (destroyOnTargetCollision)
                    Destroy(this.gameObject);
            }
        }
    
}