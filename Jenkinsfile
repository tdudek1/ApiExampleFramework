pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps{
                bat 'msbuild -t:restore ApiExampleFramework\\ApiExampleFramework.csproj'
                bat 'msbuild -t:restore ApiExampleFramework.Tests\\ApiExampleFramework.Tests.csproj'
                bat 'msbuild .' 
            }
        }            
    }
}