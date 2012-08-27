// JScript File

function InsertSampleMovie(strUrl, w, h)
{
  document.write('<object classid="clsid: 02BF25D5-8C17-4B23-BC80-D3488ABDDC6B" standby="loading..."\n');
  document.write('codebase="http://www.apple.com/qtactivex/qtplugin.cab#version=6,0,2,0" \n');
  document.write('width="' + w + '" height="' + h + '" align="middle">\n');
  document.write('<param name="src" value="' + strUrl +'" />\n');
  document.write('<param name="autoplay" value="false" />\n');
  document.write('<embed src="' + strUrl + '" align="middle" autoplay="false" \n');
  document.write('width="' + w + '" height="' + h + '"\n');
  document.write('pluginspage="http://www.apple.com/quicktime/download/">\n');
  document.write('</embed>\n');
  document.write('</object>\n');
}