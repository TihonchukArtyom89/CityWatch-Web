var map_center = [37.83, 47.99];
var map_center_rev = [47.99,37.83];
var map = new ol.Map({
    target: 'map_OL',
    layers: [
        new ol.layer.Tile({
            source: new ol.source.OSM()
        })
    ],
    view: new ol.View({
        center: ol.proj.fromLonLat(map_center),
        zoom: 10
    })
});
ymaps.ready(init);
        function init(){
            var myMap = new ymaps.Map("map_yandex", {
                center: map_center_rev,
                zoom: 7
            });
        }
