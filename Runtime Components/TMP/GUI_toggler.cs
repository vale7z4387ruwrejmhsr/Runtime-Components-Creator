using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_toggler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if(Canvas == null)
       {
          Debug.LogError("Canvas cannot be null");
       }
       else 
       {
	     Texture2D tex = new Texture2D(2, 2);
	     byte[] UISprite = new byte[] 
          {
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E,
	0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x02, 0xA8, 0x49, 0x44,
	0x41, 0x54, 0x78, 0x9C, 0xED, 0x57, 0x4D, 0x68, 0x1A, 0x41, 0x14, 0x7E,
	0xEA, 0xBA, 0x1A, 0x2F, 0xF5, 0xE0, 0x21, 0x50, 0x45, 0x84, 0x88, 0x78,
	0x28, 0x04, 0x45, 0x04, 0x89, 0x08, 0x85, 0xC2, 0xF6, 0x24, 0x11, 0x44,
	0x72, 0x13, 0x82, 0x81, 0x8A, 0x3F, 0xF8, 0x43, 0x45, 0xD2, 0x63, 0xA0,
	0xA4, 0xF8, 0x73, 0x11, 0x84, 0x48, 0x6E, 0x81, 0x90, 0x4B, 0x88, 0x87,
	0x42, 0xA0, 0x50, 0x28, 0x01, 0x41, 0x44, 0x09, 0x04, 0x0A, 0xE2, 0xC9,
	0x28, 0x81, 0xE4, 0x2C, 0x88, 0xBF, 0xF4, 0xCD, 0xE2, 0x2E, 0xD6, 0x43,
	0x9B, 0x15, 0x17, 0x2F, 0x7E, 0xF0, 0x31, 0xBB, 0x3B, 0x6F, 0xDF, 0x7C,
	0x33, 0x6F, 0x67, 0xE7, 0x3D, 0x6A, 0x38, 0x1C, 0xC2, 0x3C, 0xE2, 0xF1,
	0x38, 0xD8, 0xED, 0x76, 0x70, 0x3A, 0x9D, 0x70, 0x7D, 0x7D, 0x0D, 0xF5,
	0x7A, 0x1D, 0x9A, 0xCD, 0x26, 0x4C, 0xA7, 0x53, 0x10, 0x02, 0xA9, 0x54,
	0x0A, 0x26, 0x93, 0x09, 0xAC, 0x56, 0x2B, 0x78, 0x3C, 0x1E, 0xB8, 0xBB,
	0xBB, 0x83, 0x6A, 0xB5, 0x0A, 0xB9, 0x5C, 0xEE, 0x2F, 0x3B, 0x0A, 0xD6,
	0x8C, 0x7F, 0x09, 0x30, 0x21, 0x8F, 0x90, 0x2E, 0xE4, 0x2E, 0x52, 0x26,
	0xD0, 0xF7, 0x04, 0x79, 0x8F, 0xFC, 0x85, 0x3C, 0x43, 0x36, 0x85, 0x08,
	0x88, 0x1F, 0x1C, 0x1C, 0x9C, 0x04, 0x83, 0xC1, 0xAD, 0xE3, 0xE3, 0x63,
	0x76, 0x29, 0xC9, 0x92, 0x0A, 0x01, 0x86, 0x4C, 0x86, 0xA1, 0xB3, 0x62,
	0x08, 0xAD, 0xE8, 0xEB, 0x13, 0xFA, 0xFA, 0x82, 0x8F, 0x73, 0x8B, 0x76,
	0x8B, 0x02, 0x68, 0x64, 0xB9, 0xD3, 0xE9, 0x30, 0x57, 0x57, 0x57, 0xA0,
	0xD3, 0xE9, 0x60, 0x59, 0x10, 0xC1, 0x66, 0xB3, 0x99, 0xA5, 0xCB, 0xE5,
	0xDA, 0xBA, 0xB8, 0xB8, 0xC8, 0xE2, 0xE3, 0x0F, 0x48, 0x37, 0x92, 0xFF,
	0xF0, 0xA8, 0x76, 0xBB, 0xCD, 0xBF, 0x74, 0x73, 0x73, 0xF3, 0x4D, 0xAF,
	0xD7, 0x33, 0xC9, 0x64, 0x12, 0x56, 0x09, 0x32, 0x91, 0x74, 0x3A, 0x0D,
	0x99, 0x4C, 0x86, 0x29, 0x14, 0x0A, 0x5F, 0xDD, 0x6E, 0x77, 0x82, 0x17,
	0x30, 0x67, 0xF7, 0x0E, 0x67, 0x1D, 0xAA, 0x54, 0x2A, 0xEC, 0x0D, 0xF9,
	0xEA, 0xC7, 0xE3, 0x31, 0xDB, 0x0A, 0xDD, 0x01, 0x1C, 0xC8, 0x2A, 0x10,
	0x52, 0x14, 0xC5, 0xB6, 0xE1, 0x70, 0x18, 0xF6, 0xF6, 0xF6, 0xA2, 0x28,
	0xE0, 0x1C, 0xBB, 0x7F, 0xB3, 0x02, 0x70, 0xD6, 0x9C, 0xFD, 0x21, 0x6E,
	0x41, 0x99, 0x5C, 0x2E, 0x67, 0x07, 0x5E, 0xDC, 0x9E, 0xCB, 0x80, 0x13,
	0x4F, 0xFC, 0xD1, 0x34, 0x0D, 0x0A, 0x85, 0x02, 0xA2, 0xD1, 0xA8, 0xAC,
	0x5C, 0x2E, 0x1F, 0x62, 0x37, 0xBB, 0x0A, 0x14, 0x37, 0x63, 0x04, 0x93,
	0xCF, 0xE7, 0x61, 0x30, 0x18, 0xC0, 0x64, 0x32, 0x81, 0x55, 0x83, 0x4C,
	0x88, 0xF8, 0x75, 0x38, 0x1C, 0x90, 0x4A, 0xA5, 0x18, 0x5E, 0xC0, 0xD3,
	0xD3, 0x13, 0x67, 0x63, 0xD0, 0x68, 0x34, 0xA2, 0x0C, 0xCE, 0x81, 0xF8,
	0x56, 0xAB, 0xD5, 0xF0, 0xF2, 0xF2, 0xF2, 0x96, 0x7B, 0x46, 0x8D, 0x46,
	0x23, 0xEE, 0x9A, 0x96, 0x48, 0x24, 0x20, 0x36, 0x94, 0x4A, 0x25, 0xF4,
	0x7A, 0xBD, 0x37, 0xBC, 0x00, 0x58, 0x33, 0x36, 0x02, 0x36, 0x02, 0x36,
	0x02, 0x36, 0x02, 0x36, 0x02, 0x28, 0x72, 0xFC, 0xCE, 0x30, 0xC4, 0x73,
	0x81, 0x9E, 0xBB, 0x17, 0x05, 0xFD, 0x7E, 0x1F, 0x54, 0x2A, 0x55, 0x8F,
	0x17, 0xB0, 0xBD, 0xBD, 0xCD, 0x5D, 0x3F, 0x3E, 0x3F, 0x3F, 0xEF, 0x68,
	0xB5, 0x5A, 0x51, 0x05, 0xE0, 0x18, 0x80, 0x63, 0x3E, 0xF2, 0x02, 0xC8,
	0xF9, 0x3C, 0xC3, 0x2D, 0xE6, 0xED, 0x21, 0xB1, 0x05, 0xD4, 0x6A, 0x35,
	0x52, 0x77, 0xFC, 0xE0, 0x05, 0x90, 0xA2, 0x61, 0x86, 0x33, 0x92, 0xBD,
	0xEE, 0xEF, 0xEF, 0xCB, 0x84, 0x66, 0xC0, 0xAF, 0x05, 0x39, 0xFA, 0x31,
	0x27, 0x9C, 0x5C, 0x5E, 0x5E, 0x9E, 0xF3, 0x02, 0x48, 0xF5, 0x33, 0xC3,
	0x83, 0xD7, 0xEB, 0x2D, 0xA2, 0x41, 0x28, 0x12, 0x89, 0x88, 0x22, 0xA0,
	0x58, 0x2C, 0x82, 0xCF, 0xE7, 0x2B, 0x60, 0x1A, 0xF8, 0xC0, 0x0B, 0x88,
	0xC5, 0x62, 0xF3, 0x36, 0x09, 0xCC, 0x0B, 0x77, 0xB2, 0xD9, 0x2C, 0x83,
	0x86, 0xB0, 0xAA, 0x70, 0x74, 0xBB, 0x5D, 0x20, 0x69, 0x3E, 0x66, 0x42,
	0xB7, 0x58, 0x9A, 0x7D, 0x9E, 0xEF, 0x5B, 0xDC, 0x86, 0x43, 0x8C, 0xCF,
	0x47, 0x6C, 0xE3, 0x7E, 0xBF, 0xFF, 0x24, 0x10, 0x08, 0x6C, 0x59, 0x2C,
	0x16, 0x30, 0x1A, 0x8D, 0x4B, 0x0D, 0xDC, 0x6A, 0xB5, 0xA0, 0xD1, 0x68,
	0x40, 0xA9, 0x54, 0xEA, 0x93, 0xC2, 0xC4, 0x60, 0x30, 0xFC, 0xB7, 0x30,
	0x61, 0x8B, 0x52, 0x44, 0x0E, 0xDB, 0xEF, 0x18, 0x9E, 0xA3, 0xD3, 0xD3,
	0xD3, 0xF7, 0x58, 0xE1, 0xEC, 0x2E, 0x23, 0x00, 0x2B, 0xAA, 0x7B, 0x9B,
	0xCD, 0xF6, 0x13, 0x63, 0x2E, 0xB8, 0x34, 0x83, 0xD9, 0x0B, 0x09, 0x10,
	0x19, 0x6B, 0xFF, 0x13, 0xFE, 0x01, 0x06, 0xD2, 0x00, 0x12, 0x3C, 0x75,
	0xD4, 0xE7, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42,
	0x60, 0x82
          };
          tex.LoadImage(UISprite);
       Texture2D Checkmark_image = new Texture2D(2, 2);
byte[] Checkmark_byte = new byte[]
{
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x40,
	0x08, 0x06, 0x00, 0x00, 0x00, 0xAA, 0x69, 0x71, 0xDE, 0x00, 0x00, 0x00,
	0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00,
	0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC,
	0x61, 0x05, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00,
	0x0E, 0xC3, 0x00, 0x00, 0x0E, 0xC3, 0x01, 0xC7, 0x6F, 0xA8, 0x64, 0x00,
	0x00, 0x04, 0xFC, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xCD, 0xD9, 0x3F,
	0x48, 0x1C, 0x4F, 0x14, 0x07, 0xF0, 0x0D, 0x81, 0x14, 0x69, 0x52, 0xA5,
	0x48, 0x20, 0x6D, 0xEA, 0xA0, 0x82, 0xC4, 0x80, 0x8D, 0xC5, 0x61, 0x67,
	0x11, 0xC4, 0xD6, 0x60, 0x65, 0x97, 0xC2, 0xDA, 0x03, 0x2D, 0x85, 0xB4,
	0x5E, 0x8A, 0x54, 0x96, 0x01, 0x6D, 0x83, 0x75, 0xAC, 0xCF, 0x54, 0x4B,
	0x2A, 0x21, 0x04, 0xE4, 0x04, 0x09, 0x48, 0x90, 0x48, 0xF4, 0x32, 0xEF,
	0xB8, 0x27, 0x6F, 0xDF, 0x7D, 0xE7, 0xDF, 0xCE, 0xEC, 0x5E, 0x8A, 0x4F,
	0x92, 0x79, 0xBB, 0xB7, 0xF7, 0xDE, 0xBC, 0x99, 0xD9, 0xE3, 0xF7, 0x2B,
	0x86, 0xC3, 0x61, 0x76, 0xBD, 0x5E, 0xAF, 0x02, 0xDD, 0x23, 0x9D, 0x9E,
	0x9E, 0x3A, 0x1D, 0x1E, 0x1E, 0x4E, 0x3C, 0x13, 0x41, 0xCF, 0xF6, 0x81,
	0xC1, 0x14, 0x28, 0x31, 0x82, 0xEE, 0x25, 0x17, 0x17, 0x17, 0x4E, 0x54,
	0xBC, 0x9C, 0x80, 0x6E, 0xB7, 0x0B, 0xFF, 0x66, 0xE8, 0x3B, 0x5C, 0x60,
	0xB0, 0x2E, 0x99, 0x08, 0xA2, 0xEF, 0xBF, 0xB9, 0xB9, 0x71, 0xB2, 0xAD,
	0x80, 0x99, 0x99, 0x19, 0xE7, 0x58, 0x7F, 0x8F, 0x0B, 0x0C, 0xD6, 0x21,
	0x13, 0x70, 0xE1, 0xFB, 0xB9, 0xB3, 0xC8, 0xEE, 0xEE, 0xEE, 0x44, 0x4C,
	0x3F, 0x07, 0xC5, 0x24, 0x99, 0x9B, 0x0B, 0x0C, 0xC6, 0x92, 0x5F, 0xBC,
	0xBF, 0xBF, 0x5F, 0x19, 0x23, 0x72, 0x7F, 0x6B, 0x54, 0x18, 0x8A, 0xA1,
	0xE7, 0xE8, 0xCE, 0x6B, 0x28, 0x57, 0x0D, 0x06, 0x63, 0xC8, 0x2F, 0xF4,
	0x25, 0xC4, 0xD0, 0x5E, 0x27, 0x54, 0xAC, 0x8E, 0xE9, 0x15, 0xA0, 0xF7,
	0xBC, 0x6F, 0x8C, 0x72, 0x96, 0x60, 0x30, 0x94, 0xFC, 0xA2, 0x18, 0x68,
	0xBF, 0x53, 0xB1, 0x3A, 0x66, 0x5B, 0x01, 0xBE, 0x33, 0x20, 0xE6, 0x4C,
	0x80, 0xC1, 0x10, 0xF2, 0x0B, 0x62, 0x71, 0x57, 0x63, 0xA0, 0xE7, 0xC4,
	0x40, 0x35, 0x10, 0x18, 0xF4, 0x91, 0x0F, 0xD6, 0x7B, 0x3E, 0xF5, 0x0C,
	0x40, 0x72, 0x4C, 0x00, 0x41, 0xB5, 0xC0, 0xA0, 0x8B, 0x7C, 0xA0, 0x6F,
	0xE9, 0xD9, 0xE8, 0x7D, 0xEE, 0xA2, 0x57, 0x40, 0xEC, 0x19, 0xE0, 0x3B,
	0x13, 0x26, 0x02, 0x2E, 0xF2, 0x41, 0x29, 0xF4, 0x5E, 0xB7, 0xB1, 0xAD,
	0x80, 0xD8, 0x33, 0x40, 0x8F, 0x65, 0x4D, 0x95, 0x81, 0x8B, 0x7C, 0x80,
	0x16, 0xDA, 0x79, 0x89, 0x3B, 0x8B, 0xE4, 0xF8, 0x1D, 0xE0, 0xBB, 0xCE,
	0x75, 0x55, 0x8A, 0xB4, 0x91, 0x1F, 0xF4, 0xED, 0xF9, 0xFF, 0xE9, 0x77,
	0x80, 0xEF, 0x3A, 0xD5, 0x36, 0x51, 0xAC, 0x26, 0x3F, 0xE0, 0x5B, 0x5A,
	0xA1, 0x2B, 0x01, 0xED, 0x75, 0x42, 0xC5, 0xEA, 0x18, 0x15, 0x2F, 0x27,
	0x20, 0xF5, 0x0C, 0xD0, 0x63, 0x58, 0x34, 0x93, 0x37, 0xE6, 0x84, 0xF6,
	0x3B, 0x15, 0xAB, 0x63, 0xB6, 0x15, 0x10, 0xDB, 0x08, 0xD7, 0x18, 0x16,
	0x4E, 0xE4, 0x07, 0x72, 0xE3, 0xAE, 0x32, 0x2A, 0x56, 0xC7, 0x34, 0xF4,
	0x1C, 0x29, 0xE4, 0x1E, 0xC4, 0x5B, 0x7C, 0xEC, 0x9E, 0x0F, 0x39, 0x03,
	0x64, 0x97, 0xA9, 0xF3, 0xDC, 0x69, 0x9B, 0xD0, 0xE2, 0x74, 0xA7, 0x43,
	0x38, 0x8B, 0x4F, 0x59, 0x5A, 0x2E, 0xDC, 0x55, 0x9E, 0x00, 0x17, 0xBE,
	0x97, 0x3F, 0xDB, 0xE8, 0x19, 0x20, 0x2F, 0x34, 0x89, 0x8B, 0xF7, 0xB1,
	0xAD, 0x80, 0xD4, 0xC6, 0xC8, 0x71, 0x50, 0xF1, 0xFA, 0x01, 0x9A, 0xEF,
	0x3A, 0xC2, 0x9D, 0x45, 0xDA, 0xF8, 0x1D, 0xC0, 0x2B, 0x61, 0xA2, 0xF8,
	0xD4, 0x3D, 0x1F, 0x72, 0x06, 0xC8, 0xFD, 0xAD, 0x51, 0xE2, 0x28, 0x86,
	0x9E, 0x93, 0xDA, 0x18, 0x9A, 0x84, 0x4A, 0x40, 0x7F, 0x20, 0x75, 0x6C,
	0x83, 0xF6, 0x3A, 0xA1, 0x62, 0x75, 0x8C, 0x8A, 0x97, 0x13, 0x10, 0xBB,
	0xC7, 0x7D, 0xE3, 0xCA, 0xA0, 0x2D, 0x68, 0xBF, 0x53, 0xB1, 0x3A, 0x66,
	0x5B, 0x01, 0x39, 0x1B, 0x55, 0xB9, 0x10, 0x4A, 0x3F, 0x30, 0x16, 0x77,
	0x35, 0xC2, 0x86, 0xF9, 0xDC, 0xB6, 0x7E, 0x4E, 0x0E, 0xD9, 0xF7, 0xBC,
	0x1E, 0x23, 0xDC, 0xD9, 0x40, 0xAF, 0xE7, 0xE7, 0xE7, 0xFF, 0x98, 0x49,
	0x1F, 0x9A, 0xCF, 0x66, 0x9F, 0x84, 0xCA, 0x20, 0x66, 0xE9, 0x84, 0x8C,
	0x6D, 0xF4, 0x3E, 0x77, 0x78, 0xD6, 0xE9, 0x74, 0x7E, 0x9A, 0xE7, 0x0E,
	0x89, 0xD9, 0xBF, 0x9F, 0x68, 0x0F, 0xE7, 0x74, 0xDF, 0xB1, 0x90, 0xCE,
	0xE5, 0xA2, 0xF7, 0xBA, 0xC5, 0xA3, 0xF5, 0xF5, 0xF5, 0xAF, 0x5C, 0xFC,
	0xDA, 0xDA, 0x5A, 0xFF, 0xFA, 0xFA, 0xFA, 0xB1, 0x51, 0xE4, 0x34, 0x4A,
	0xC8, 0x57, 0xBC, 0xAF, 0xB3, 0xBE, 0xEB, 0x08, 0xBD, 0xEB, 0x3D, 0x7A,
	0x5C, 0xFC, 0xE2, 0xE2, 0xE2, 0xAF, 0xB3, 0xB3, 0xB3, 0x97, 0x46, 0x91,
	0xDB, 0x44, 0x62, 0xBE, 0x3D, 0x1D, 0x3B, 0x46, 0xC0, 0x21, 0xA7, 0x6D,
	0x70, 0xF1, 0xB3, 0xB3, 0xB3, 0x77, 0xC7, 0xC7, 0xC7, 0x6F, 0x8D, 0xA2,
	0x09, 0x95, 0xC4, 0x74, 0x27, 0x53, 0xC7, 0x2E, 0xE0, 0xB0, 0x63, 0xF7,
	0x87, 0x1E, 0xD9, 0xDB, 0xDB, 0xFB, 0x60, 0x14, 0x4D, 0x81, 0xC9, 0x65,
	0x42, 0x27, 0xB6, 0xF5, 0xD4, 0x06, 0x07, 0x1E, 0xA9, 0x1C, 0x7A, 0x74,
	0x06, 0xD0, 0x59, 0xA0, 0xCE, 0x86, 0xAC, 0x60, 0x72, 0x19, 0x6C, 0x73,
	0x11, 0xF4, 0x6F, 0x75, 0x6D, 0x04, 0x24, 0x53, 0x39, 0xF4, 0x96, 0x96,
	0x96, 0x06, 0xE7, 0xE7, 0xE7, 0x2F, 0x8C, 0xA2, 0x49, 0xA3, 0x3D, 0xDB,
	0x80, 0x2E, 0x17, 0x62, 0x9B, 0x84, 0x9D, 0x9D, 0x1D, 0xED, 0x23, 0xDF,
	0x3F, 0x37, 0x37, 0xF7, 0xF7, 0xE4, 0xE4, 0xA4, 0x63, 0x14, 0x4D, 0x43,
	0xC9, 0xE7, 0xE2, 0x9C, 0x04, 0xDB, 0xA1, 0x47, 0xE8, 0xB3, 0xEA, 0x59,
	0x8D, 0x81, 0xC1, 0x8C, 0xAC, 0x93, 0x60, 0x3B, 0xF4, 0x36, 0x37, 0x37,
	0xBF, 0xDC, 0xDE, 0xDE, 0x3E, 0x34, 0x8A, 0x36, 0xA0, 0xA4, 0x73, 0x83,
	0x93, 0x30, 0x18, 0x0C, 0xC8, 0x73, 0x79, 0xE8, 0x2D, 0x2F, 0x2F, 0xFF,
	0xB8, 0xBC, 0xBC, 0x7C, 0x6A, 0x14, 0x6D, 0x41, 0x09, 0x37, 0x61, 0x62,
	0x12, 0xF4, 0xA1, 0x47, 0xAB, 0xA0, 0xDF, 0xEF, 0xBF, 0x31, 0x8A, 0x36,
	0xA1, 0x64, 0x9B, 0x52, 0x99, 0x84, 0xD5, 0xD5, 0xD5, 0x6F, 0x72, 0x7C,
	0x70, 0x70, 0xF0, 0xDE, 0x28, 0xDA, 0x86, 0x12, 0x6D, 0x52, 0x65, 0x12,
	0xD8, 0xD6, 0xD6, 0xD6, 0xE7, 0xBB, 0xBB, 0xBB, 0x07, 0x46, 0xD1, 0x36,
	0x94, 0x64, 0xD3, 0x2A, 0x93, 0xB0, 0xB2, 0xB2, 0xF2, 0xFD, 0xEA, 0xEA,
	0xEA, 0x89, 0x51, 0x4C, 0x03, 0x4A, 0xB0, 0x0D, 0xA3, 0x49, 0x58, 0x58,
	0x58, 0xF8, 0x5D, 0x96, 0xE5, 0x2B, 0xA3, 0x98, 0x16, 0x94, 0x5C, 0x5B,
	0xBA, 0x47, 0x47, 0x47, 0xEF, 0x8C, 0x62, 0x5A, 0xE8, 0x3F, 0x08, 0xA3,
	0xC4, 0x82, 0x99, 0x2E, 0xC2, 0x78, 0x28, 0x4A, 0xA2, 0x1C, 0x77, 0x42,
	0xEF, 0x4D, 0x7A, 0x47, 0xEB, 0x98, 0x94, 0x7A, 0x9D, 0xFF, 0x77, 0xC0,
	0xE8, 0x0F, 0x94, 0x5C, 0xA8, 0x94, 0x49, 0xE0, 0x4E, 0xE8, 0x7D, 0x49,
	0xEF, 0x67, 0x1D, 0x93, 0x52, 0xAF, 0x73, 0xF1, 0xF7, 0x13, 0x30, 0xAD,
	0x49, 0x90, 0x2B, 0x80, 0xD1, 0xBB, 0x59, 0xC7, 0xA4, 0xD4, 0xEB, 0xB2,
	0x78, 0x52, 0x19, 0xA0, 0x24, 0x43, 0xD5, 0x99, 0x04, 0x5E, 0x01, 0x8C,
	0xDE, 0xCB, 0x3A, 0x26, 0xA5, 0x5E, 0x97, 0xB5, 0xB2, 0x89, 0x00, 0x4A,
	0x34, 0x54, 0xEC, 0x24, 0x50, 0x52, 0xE5, 0xB8, 0x33, 0x68, 0x9F, 0x4A,
	0xE6, 0xB7, 0x02, 0x8C, 0x87, 0xD2, 0x75, 0x32, 0x18, 0x44, 0xC9, 0x86,
	0xA2, 0xDF, 0xF9, 0x28, 0x8E, 0x70, 0x67, 0xD0, 0x3E, 0x95, 0xCC, 0x6F,
	0x05, 0x18, 0x0F, 0x85, 0x6A, 0x64, 0x30, 0x48, 0x50, 0xC2, 0xB9, 0xC9,
	0x15, 0x60, 0x63, 0x7E, 0x2B, 0xC0, 0x78, 0x28, 0x54, 0x9B, 0x04, 0x83,
	0x0C, 0x25, 0x9D, 0x13, 0xAF, 0x00, 0x9B, 0x90, 0x7B, 0x5C, 0x50, 0x4D,
	0x1A, 0x0C, 0x4A, 0x3A, 0xE9, 0x9C, 0x28, 0xC9, 0x72, 0xDC, 0x29, 0xBD,
	0x67, 0x73, 0xBD, 0xE7, 0x7D, 0x60, 0x50, 0x43, 0xC9, 0xE7, 0xC0, 0x9D,
	0xD2, 0x7B, 0x36, 0xE7, 0x7B, 0xDE, 0x07, 0x06, 0x11, 0x54, 0x40, 0x2A,
	0xB9, 0x02, 0x58, 0xEE, 0xF7, 0xBC, 0x0F, 0x0C, 0xDA, 0xA0, 0x22, 0x52,
	0xF0, 0x0A, 0x60, 0x4D, 0xBC, 0xE7, 0x7D, 0x60, 0xD0, 0x05, 0x15, 0x52,
	0x17, 0x25, 0x5D, 0x8E, 0x3B, 0x87, 0xF6, 0x71, 0x0C, 0x94, 0x6B, 0x08,
	0x18, 0xF4, 0x41, 0xC5, 0xD4, 0xC1, 0x9D, 0x43, 0xFB, 0x38, 0x06, 0xCA,
	0x31, 0x14, 0x0C, 0x86, 0x40, 0x05, 0xC5, 0x92, 0x2B, 0xA0, 0x2E, 0x94,
	0x5B, 0x0C, 0x18, 0x0C, 0x85, 0x8A, 0x8A, 0xC1, 0x2B, 0xA0, 0x2E, 0x94,
	0x53, 0x2C, 0x18, 0x8C, 0x81, 0x0A, 0x0B, 0x45, 0x45, 0x94, 0xE3, 0x4E,
	0xEA, 0x3D, 0x9D, 0xEB, 0x3D, 0xEF, 0x03, 0x83, 0xB1, 0x50, 0x71, 0x21,
	0xB8, 0x93, 0x7A, 0x4F, 0xE7, 0x7C, 0xCF, 0xFB, 0xC0, 0x60, 0x1D, 0xA8,
	0x40, 0x1F, 0xB9, 0x02, 0x58, 0xEE, 0xF7, 0xBC, 0x0F, 0x0C, 0xD6, 0x85,
	0x8A, 0x74, 0xE1, 0x15, 0xC0, 0x9A, 0x78, 0xCF, 0xFB, 0xC0, 0x60, 0x0A,
	0x54, 0xA8, 0x0D, 0x15, 0x55, 0x8E, 0x3B, 0x8B, 0xF6, 0xB9, 0x84, 0xBE,
	0x2B, 0x07, 0x18, 0x4C, 0x85, 0x8A, 0x45, 0xB8, 0xB3, 0x68, 0x9F, 0x4B,
	0xE8, 0x3B, 0xF2, 0x18, 0x16, 0xFF, 0x00, 0xA5, 0xFC, 0xC7, 0xDD, 0x78,
	0x38, 0x1B, 0x7B, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE,
	0x42, 0x60, 0x82
};
Checkmark_image.LoadImage(Checkmark_byte);
          GameObject Toggle = new GameObject();
          Toggle.transform.SetParent(Canvas.transform);
          Toggle.name = "Toggle";
          Toggle.AddComponent<Toggle>();
          Toggle.GetComponent<Toggle>().isOn = true;
          Toggle.GetComponent<RectTransform>().sizeDelta = size;
          GameObject Background = new GameObject();
          Background.transform.SetParent(Toggle.transform);
          Background.name = "Background";  
          Background.AddComponent<Image>();
          Background.GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10,10,10,10));
          Toggle.GetComponent<Toggle>().targetGraphic = Background.GetComponent<Image>();
          Background.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 1);
          Background.GetComponent<RectTransform>().anchorMax = new Vector2 (0, 1);
          GameObject Label = new GameObject();
          Label.transform.SetParent(Toggle.transform);
          Label.name = "Label"; 
          Label.AddComponent<Text>();
          Label.GetComponent<Text>().text = "Toggle";
          Label.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
          GameObject Checkmark = new GameObject();
          Checkmark.transform.SetParent(Background.transform);
          Checkmark.name = "Checkmark";
          Checkmark.AddComponent<Image>(); 
          Checkmark.GetComponent<Image>().sprite = Sprite.Create(Checkmark_image, new Rect(0.0f, 0.0f, Checkmark_image.width, Checkmark_image.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0,0,0,0));
          Checkmark.GetComponent<RectTransform>().offsetMin = new Vector2(-20,-20);
          Checkmark.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          Toggle.GetComponent<Toggle>().graphic = Checkmark.GetComponent<Image>();       
       }
    }
    public GameObject Canvas;
    public Vector2 size = new Vector2 (160, 20);
}
