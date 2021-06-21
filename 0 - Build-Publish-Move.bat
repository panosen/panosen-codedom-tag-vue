@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Tag.Vue\bin\Release\Panosen.CodeDom.Tag.Vue.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Vue.Element\bin\Release\Panosen.CodeDom.Tag.Vue.Element.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Vue.Pano\bin\Release\Panosen.CodeDom.Tag.Vue.Pano.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.CodeDom.Tag.Vue.Vuetify\bin\Release\Panosen.CodeDom.Tag.Vue.Vuetify.*.nupkg D:\LocalSavoryNuget\

pause