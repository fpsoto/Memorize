﻿using Android;
using Android.Content;
using Android.Views;
using Android.Widget;

public class ImageAdapter : BaseAdapter
{
    Context context;

    public ImageAdapter(Context c)
    {
        context = c;
    }

    public override int Count
    {
        get { return thumbIds.Length; }
    }

    public override Java.Lang.Object GetItem(int position)
    {
        return null;
    }

    public override long GetItemId(int position)
    {
        return 0;
    }

    // create a new ImageView for each item referenced by the Adapter
    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        ImageView imageView;

        if (convertView == null)
        {  // if it's not recycled, initialize some attributes
            imageView = new ImageView(context);
            imageView.LayoutParameters = new GridView.LayoutParams(105, 105);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetPadding(8, 8, 8, 8);
        }
        else
        {
            imageView = (ImageView)convertView;
        }

        imageView.SetImageResource(thumbIds[position]);
        return imageView;
    }

    // references to our images
    int[] thumbIds = {
       Memorize.Resource.Drawable.sample_2, Memorize.Resource.Drawable.sample_3,
       Memorize.Resource.Drawable.sample_4, Memorize.Resource.Drawable.sample_5,
        Memorize.Resource.Drawable.sample_6,Memorize. Resource.Drawable.sample_7,
       Memorize. Resource.Drawable.sample_0,Memorize. Resource.Drawable.sample_1,
       Memorize. Resource.Drawable.sample_2,Memorize. Resource.Drawable.sample_3,
      Memorize.  Resource.Drawable.sample_4,Memorize. Resource.Drawable.sample_5,
      Memorize.  Resource.Drawable.sample_6,Memorize. Resource.Drawable.sample_7,
      Memorize.  Resource.Drawable.sample_0,Memorize. Resource.Drawable.sample_1,
       Memorize. Resource.Drawable.sample_2,Memorize. Resource.Drawable.sample_3,
      Memorize.  Resource.Drawable.sample_4, Memorize.Resource.Drawable.sample_5,
       Memorize. Resource.Drawable.sample_6,Memorize. Resource.Drawable.sample_7
    };
}