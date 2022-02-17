pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps{
                bat 'msbuild -t:restore ApiExampleFramework.sln'
                bat 'msbuild .' 
            }
        }            
    }
}