using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public Color AddColorWithEnter;
    private Color _currentAddedColor;
    private Color _ClearColor = new Color(1, 1, 1,1);
    private bool _isClear;
    public float Health = 100;
    public GameObject TreeDropedElement;
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _currentAddedColor = _ClearColor;
    }
    private void FixedUpdate()
    {
        if (_isClear)
        { _currentAddedColor = Color.Lerp(_currentAddedColor, _ClearColor, Time.deltaTime); }
        _renderer.color =  _currentAddedColor;
    }

    // Update is called once per frame
    public void OnClick()
    {
        Health -= 25;
        if(Health<=0)
        {
            int count = Random.Range(3, 5);
            var p = transform.position;
            for(int i=0;i<count;i++)
            {
                var go= Instantiate(TreeDropedElement, new Vector3(p.x, p.y + i, p.z), Quaternion.identity);
               
            }
            Destroy(gameObject);    
        }
    }
    public void OnEnter()
    {
        _currentAddedColor = AddColorWithEnter;
        _isClear = false;
    }
    public void OnExit()
    {
        _isClear = true;
    }
}
